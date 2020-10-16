<template>
  <div class="publicnav">
    <div id="link-tag-switch">
      <v-switch
        v-model="linkTagSwitch"
        inset
        :label="linkTagListStatus"
      ></v-switch>
    </div>

    <v-btn @click="addSourceDialog = true" id="addsourcebtn">
      + Add New Source
    </v-btn>
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
            value=""
            filled
            autofocus
            placeholder="Past Blog Rss URL"
          ></v-text-field>
        </v-card-text>
        <v-card-actions>
          <v-btn @click="addSourceDialog = false">
            Ok
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>

    <LinkList></LinkList>

    <v-divider></v-divider>

    <v-text-field
      placeholder="Search Source"
      prepend-inner-icon="mdi-magnify"
    ></v-text-field>
  </div>
</template>

<script lang="ts">
import { Vue, Component, Watch } from "vue-property-decorator";
import LinkList from "./LinkList.vue";

@Component({
  components: {
    LinkList
  }
})
export default class PublicNavDrawer extends Vue {
  // data
  linkTagSwitch = false;
  addSourceDialog = false;

  // computed
  get linkTagListStatus(): string {
    return this.$store.state.linkTagListStatus;
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
</style>


