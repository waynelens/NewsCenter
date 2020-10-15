<template>
  <v-app>
    <v-app-bar app flat>
      <PublicHeader></PublicHeader>
    </v-app-bar>

    <v-main>
      content
    </v-main>
  </v-app>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import PublicHeader from "./components/PublicHeader.vue";

@Component({
  components: {
    PublicHeader,
  }
})
export default class App extends Vue {}
</script>
