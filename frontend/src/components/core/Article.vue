<template>
  <div class="article">
    <v-card max-width="300" rounded="xl" color="bg3">
      <v-card-title d-flex class="justify-space-between">
        <v-icon large left>
          mdi-twitter
        </v-icon>
        <span class="title">Twitter</span>
        <v-icon>
          mdi-bookmark-outline
        </v-icon>
      </v-card-title>

      <v-card-text class="title">
        "Turns out semicolon-less style is easier and safer in TS because most
        gotcha edge cases are type invalid as well."
      </v-card-text>

      <v-card-actions>
        <v-icon class="mr-1">
          mdi-thumb-up-outline
        </v-icon>
        <span class="subheading mr-2">256</span>
        <span class="mr-1">·</span>
        <v-icon class="mr-1">
          mdi-comment-processing-outline
        </v-icon>
        <span class="subheading">45</span>
      </v-card-actions>
    </v-card>
  </div>
</template>

<script lang="ts">
import { Vue, Component } from "vue-property-decorator";

@Component
export default class PublicArticle extends Vue {}
</script>

<style>
.article{
  margin: 15px;
}
</style>


