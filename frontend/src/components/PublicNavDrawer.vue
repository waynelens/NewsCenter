<template>
  <div class="publicnav">
    <v-list>
      <v-list-item link>
        <v-list-item-content>
          <v-switch v-model="linkTagSwitch"></v-switch>
        </v-list-item-content>
      </v-list-item>
    </v-list>

    <v-divider></v-divider>

    <LinkList></LinkList>

    <v-divider></v-divider>

    <v-text-field
      placeholder="Search Source"
      prepend-inner-icon="mdi-magnify"
    ></v-text-field>
  </div>
</template>

<script lang="ts">
import { Vue, Component } from "vue-property-decorator";
import LinkList from "./LinkList.vue";

@Component({
  components: {
    LinkList
  }
})
export default class PublicNavDrawer extends Vue {
  // data
  test = false;
  linkTagSwitch = false;
}
</script>

<style>
</style>


