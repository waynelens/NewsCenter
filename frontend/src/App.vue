<template>
  <v-app>
    <v-app-bar app flat>
      <PublicHeader></PublicHeader>
    </v-app-bar>

    <!-- <v-navigation-drawer expand-on-hover app mini-variant mini-variant-width="256"> -->
    <v-navigation-drawer app>
      <PublicNavDrawer></PublicNavDrawer>
    </v-navigation-drawer>

    <v-main>
      <router-view></router-view>
      <Article></Article>
    </v-main>
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
    Article
  }
})
export default class App extends Vue {}
</script>
