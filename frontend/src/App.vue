<template>
  <v-app>
    <v-app-bar app flat>
      <PublicHeader></PublicHeader>
    </v-app-bar>

    <v-navigation-drawer bottom expand-on-hover app>
      <PublicNavDrawer></PublicNavDrawer>
    </v-navigation-drawer>

    <v-content>
      <router-view></router-view>
      <Article></Article>
    </v-content>
  </v-app>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import PublicHeader from "./components/PublicHeader.vue";
import PublicNavDrawer from "./components/PublicNavDrawer.vue";
import Article from "./components/Article.vue";

@Component({
  components: {
    PublicHeader,
    PublicNavDrawer,
    Article,
  }
})
export default class App extends Vue {}
</script>
