<template>
  <div class="home">
    content
    <Bread></Bread>
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import Bread from "../components/Bread.vue";

@Component({
  components:{
    Bread,
  }
})
export default class Home extends Vue {}
</script>
