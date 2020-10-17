<template>
  <div class="home">
    <div id="side-line-number">
      <v-icon>
        mdi-menu
      </v-icon>
      <span v-for="(item, index) in 50" :key="index">{{ index }}</span>
    </div>

    <div id="main-content">
      <div id="bread">
        <v-icon>
          mdi-magnify
        </v-icon>
        <v-icon>
          mdi-flash
        </v-icon>
        <v-btn>POPLUAR</v-btn>
        <v-btn>RECENT</v-btn>
      </div>

      <div id="articles">
        <CoreArticle></CoreArticle>
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";

@Component
export default class Home extends Vue {}
</script>

<style>
.home {
  display: flex;
}

#side-line-number {
  border-right: 1px solid #aaa;
  writing-mode: vertical-lr;
  height: 100vh;
  padding: 20px 3px;
}

#side-line-number > span {
  writing-mode: horizontal-tb;
  color: #aaa;
  font-size: 12px;
  margin-left: 8px;
}
</style>
