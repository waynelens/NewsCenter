<template>
  <div class="linklist">
    <div id="addLink">
      <v-icon>mdi-plus-thick</v-icon>
      <p>Add new source</p>
    </div>

    <v-list flat>
      <v-subheader>MY PUBLIC SOURCES</v-subheader>
      <v-list-item-group v-model="link" color="primary">
        <v-list-item v-for="(item, index) in linkGroup" :key="index">
          <v-list-item-icon>
            <v-icon>
                {{item.icon}}
            </v-icon>
          </v-list-item-icon>
          <v-list-item-content>
            <v-list-item-title v-text="item.title"></v-list-item-title>
          </v-list-item-content>
        </v-list-item>
      </v-list-item-group>
    </v-list>
  </div>
</template>

<script lang="ts">
import { Vue, Component } from "vue-property-decorator";

@Component
export default class LinkList extends Vue {
    link = 1;
    linkGroup = [
        {title: "80 Level",icon: "mdi-clock"},
        {title: "Hacker News",icon: "mdi-flag"},
    ]
}
</script>

<style>
#addLink {
  display: flex;
}
</style>


