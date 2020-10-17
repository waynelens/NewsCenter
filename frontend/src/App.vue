<template>
  <v-app>
    <v-app-bar app flat>
      <PublicHeader></PublicHeader>
    </v-app-bar>

    <v-navigation-drawer
      expand-on-hover
      app
      mini-variant
      mini-variant-width="1"
    >
      <PublicNavDrawer></PublicNavDrawer>
    </v-navigation-drawer>

    <v-main>
      <router-view></router-view>
    </v-main>
  </v-app>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";

@Component
export default class App extends Vue {}
</script>
