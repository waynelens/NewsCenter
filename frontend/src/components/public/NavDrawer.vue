<template>
  <div class="publicnav">
    <div id="link-tag-switch">
      <v-switch
        v-model="linkTagSwitch"
        inset
        :label="linkTagListStatus"
      ></v-switch>
    </div>

    <div id="add-source">
      <v-btn @click="addSourceDialog = true" id="addsourcebtn">
        + Add New Source
      </v-btn>
      <!--TODO: 這dialog 之後要拉出去，輸入完之後有很多變化-->
      <v-dialog v-model="addSourceDialog" width="20%">
        <v-card>
          <v-card-title>
            Add New Source
          </v-card-title>
          <v-card-text>
            <p>
              Have an idea for a new source? Insert its link below to add it to
              your feed.
            </p>
            <v-text-field
              v-model="rssFeedUrl"
              filled
              autofocus
              placeholder="Past Blog Rss URL"
            ></v-text-field>
          </v-card-text>
          <v-card-actions>
            <v-btn @click="postRssFeedUrl">
              Ok
            </v-btn>
          </v-card-actions>
        </v-card>
      </v-dialog>
    </div>

    <CoreLinkList></CoreLinkList>

    <div id="test">
      <v-text-field
        placeholder="Search Source"
        prepend-inner-icon="mdi-magnify"
        filled
      ></v-text-field>
    </div>
  </div>
</template>

<script lang="ts">
import { Vue, Component, Watch } from "vue-property-decorator";
import { ISourceProviderModel } from "../../model/ISourceProviderModel";

@Component
export default class PublicNavDrawer extends Vue {
  // data
  linkTagSwitch = false;
  addSourceDialog = false;
  rssFeedUrl = "";

  // computed
  get linkTagListStatus(): string {
    return this.$store.state.linkTagListStatus;
  }

  // method
  postRssFeedUrl(): void {
    const req: ISourceProviderModel = {
      rssFeed : this.rssFeedUrl,
      refCreatorId : 3
    };
  }

  //watch
  @Watch("linkTagSwitch")
  switchlinkTagListStatus(val: boolean, oldVal: boolean) {
    if (val) {
      this.$store.commit("switchlinkTagListStatus", "Tag");
    } else {
      this.$store.commit("switchlinkTagListStatus", "Link");
    }
  }
}
</script>

<style>
#link-tag-switch {
  padding-left: 40%;
}

#addsourcebtn {
  margin-left: 13%;
}

#test {
  position: fixed;
  bottom: 0;
  width: 100%;
}
</style>


