<template>
  <div class="home">
    <Header></Header>
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import Header from "@/components/layout/Header.vue";

@Component({
  components: {
    Header
  }
})
export default class Home extends Vue {}
</script>
