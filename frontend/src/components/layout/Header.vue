<template>
  <div class="container">
    <img src="../../../public/img/icons/logo.jpg" alt="logo" class="logo" />

    <div class="bookmark-switch">
      <button>Switch</button>
    </div>

    <div class="header-button-group">
      <button>Don't Disturb</button>
      <button>Latest Updates</button>
      <button>Layout Setting</button>
      <button>Sign In</button>
    </div>
  </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from "vue-property-decorator";

export default class Header extends Vue {

}
</script>

<style>
.container {
  align-items: center;
  justify-content: space-between;
  padding: 5px 15px;
}

img {
  width: 200px;
}
</style>
