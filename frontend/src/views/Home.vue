<template>
  <div class="home">
    <div id="side-line-number" :style="bg1Color">
      <v-icon>
        mdi-menu
      </v-icon>
      <span v-for="(item, index) in 50" :key="index">{{ index }}</span>
    </div>

    <div id="main-content" :style="bg1Color">
      <CoreLayoutPanel color="bg2"></CoreLayoutPanel>
      <div id="bread">
        <div id="search-article">
          <v-text-field
            prepend-inner-icon="mdi-magnify"
            placeholder="Search"
          ></v-text-field>
        </div>
        <div id="time-button">
          <v-dialog v-model="dialog" width="500">
            <template v-slot:activator="{ on, attrs }">
              <v-btn icon v-bind="attrs" v-on="on">
                <v-icon>mdi-flash</v-icon>
              </v-btn>
            </template>

            <v-card>
              <v-card-title class="headline grey lighten-2"
                >`` Privacy Policy
              </v-card-title>

              <v-card-text>
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do
                eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut
                enim ad minim veniam, quis nostrud exercitation ullamco laboris
                nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor
                in reprehenderit in voluptate velit esse cillum dolore eu fugiat
                nulla pariatur. Excepteur sint occaecat cupidatat non proident,
                sunt in culpa qui officia deserunt mollit anim id est laborum.
              </v-card-text>

              <v-divider></v-divider>

              <v-card-actions>
                <v-spacer></v-spacer>
                <v-btn color="primary" text @click="dialog = false">
                  I accept
                </v-btn>
              </v-card-actions>
            </v-card>
          </v-dialog>

          <v-btn icon>POPLUAR</v-btn>
          <v-btn icon>RECENT</v-btn>
        </div>
      </div>

      <div id="articles">
        <CoreArticle v-for="item in articles" :key="item.Id" :news="item">
        </CoreArticle>
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import VueAxios from "vue-axios";
import { Component, Vue, Watch } from "vue-property-decorator";
import { axios } from "vue/types/umd";
import { INewsModel } from "../viewmodel/INewsModel";
import { ILatestNewsModel } from "../model/ILatestNewsModel";

@Component
export default class Home extends Vue {
  // data
  articles: Array<INewsModel> = [];

  // compute
  get themeStatus(): boolean {
    return this.$store.state.themeStatus;
  }
  get bg1Color(): string {
    const prefix = "background-color:";
    return this.themeStatus
      ? prefix + this.$vuetify.theme.themes.light.bg1
      : prefix + this.$vuetify.theme.themes.dark.bg1;
  }
  get sourceStatus(): number {
    return this.$store.state.sourceStatus;
  }
  set sourceStatus(data: number) {
    this.$store.commit("switchSourceStatus", data);
  }
  get latestNewsBatch(): number {
    return this.$store.state.latestNewsBatch;
  }
  set latestNewsBatch(data: number) {
    this.$store.commit("addLatestNewsBatch", data);
  }

  // method
  scrollLoadNews(): void {
    if (window.innerHeight + window.pageYOffset >= document.body.offsetHeight) {
      console.log("出發");
      this.latestNewsBatch = this.latestNewsBatch + 1;
      const req: ILatestNewsModel = {
        sourceId: this.sourceStatus,
        batch: this.latestNewsBatch
      };
      Vue.axios
        .post("https://localhost:44302/api/News/LatestNews", req)
        .then(res => {
          res.data.forEach((data: INewsModel) => {
            this.articles.push(data);
          });
        });
    }
  }

  // life cycle
  created(): void {
    window.addEventListener("scroll", this.scrollLoadNews);
    this.sourceStatus = 0;
    this.latestNewsBatch = 1;

    const req: ILatestNewsModel = {
      sourceId: this.sourceStatus,
      batch: this.latestNewsBatch
    };
    Vue.axios
      .post("https://localhost:44302/api/News/LatestNews", req)
      .then(res => {
        res.data.forEach((data: INewsModel) => {
          this.articles.push(data);
        });
      });
  }

  // watch
  @Watch("sourceStatus")
  displayPartLatestNews(val: number, oldVal: number) {
    this.latestNewsBatch = 1;
    this.articles = [];
    
    if (val != 0) {
      const req: ILatestNewsModel = {
        sourceId: val,
        batch: this.latestNewsBatch
      };
      Vue.axios
        .post("https://localhost:44302/api/News/LatestNews", req)
        .then(res => {
          res.data.forEach((data: INewsModel) => {
            this.articles.push(data);
          });
        });
    }
  }
}
</script>

<style>
.home {
  display: flex;
}

#side-line-number {
  border-right: 1px solid #aaa;
  writing-mode: vertical-lr;
  height: 100vh;
  padding: 20px 3px;
}

#side-line-number > span {
  writing-mode: horizontal-tb;
  color: #aaa;
  font-size: 12px;
  margin-left: 8px;
}

#main-content {
  width: 100%;
}

#bread {
  padding-left: 10px;
  display: flex;
  align-items: center;
}

#bread > * {
  margin: 0 5px;
}

#search-article {
  width: 8%;
}

#time-button {
  display: flex;
  justify-content: space-around;
  width: 10%;
}

#articles {
  display: flex;
  flex-wrap: wrap;
}
</style>
