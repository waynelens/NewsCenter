<template>
  <div class="linklist">
    <v-list flat>
      <v-subheader>MY PUBLIC SOURCES</v-subheader>
      <v-list-item-group>
        <v-list-item v-for="(link, index) in linkGroup" :key="index">
          <v-list-item-icon>
            <v-icon>
              {{ link.icon }}
            </v-icon>
          </v-list-item-icon>
          <v-list-item-content>
            <v-list-item-title>{{link.title}}</v-list-item-title>
          </v-list-item-content>
        </v-list-item>
      </v-list-item-group>
    </v-list>
  </div>
</template>

<script lang="ts">
import { Vue, Component } from "vue-property-decorator";

@Component
export default class PublicLinkList extends Vue {
  linkGroup = [
    { title: "80 Level", icon: "mdi-clock" },
    { title: "Hacker News", icon: "mdi-flag" }
  ];
}
</script>

<style>
</style>


