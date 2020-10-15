<template>
  <div class="bread">
    <v-breadcrumbs :items="items" divider="-"></v-breadcrumbs>
    <v-btn>希望會出現</v-btn>
  </div>
</template>

<script lang="ts">
import { Vue, Component } from "vue-property-decorator";

@Component
export default class PublicNavDrawer extends Vue {
  items = [
    {
      text: "Dashboard",
      disabled: false,
      href: "breadcrumbs_dashboard"
    },
    {
      text: "Link 1",
      disabled: false,
      href: "breadcrumbs_link_1"
    },
    {
      text: "Link 2",
      disabled: true,
      href: "breadcrumbs_link_2"
    }
  ];
}
</script>

<style>
</style>


