<template>
  <div class="linklist">
    <v-list flat>
      <v-subheader>MY PUBLIC SOURCES</v-subheader>
      <v-list-item-group>
        <v-list-item v-for="item in linkListDisplay" :key="item.id">
          <v-list-item-icon>
            <img :src="item.logo" alt="" width="20" />
          </v-list-item-icon>
          <v-list-item-content>
            <v-list-item-title>{{ item.name }}</v-list-item-title>
            <p v-if="change">{{ item.rssFeed }}</p>
          </v-list-item-content>
        </v-list-item>
      </v-list-item-group>
    </v-list>
  </div>
</template>

<script lang="ts">
import { ISourceModel } from "@/viewmodel/ISourceModel";
import { Vue, Component, Prop, Watch } from "vue-property-decorator";

@Component
export default class PublicLinkList extends Vue {
  //data
  linkList: Array<ISourceModel> = [];
  linkListDisplay: Array<ISourceModel> = [];

  // prop
  @Prop(String) readonly searchReq: string | undefined;

  // method
  created(): void {
    Vue.axios
      .get("https://newcenterwebapi.azurewebsites.net/api/Source/GetSources")
      .then(res => {
        res.data.forEach((data: ISourceModel) => {
          this.linkList.push(data);
          this.linkListDisplay.push(data);
        });
      });
  }

  // watch
  @Watch("searchReq")
  listFilter(val: string, oldVal: string) {
    this.linkListDisplay = this.linkList.filter(x =>
      x.name.toLowerCase().includes(val.toLowerCase())
    );
  }
}
//TODO: 未來加入vuetify的 tooltips，顯示RSS
</script>

<style>
</style>


