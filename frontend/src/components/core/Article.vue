<template>
  <div class="article" @click="Direct">
    <v-card max-width="300" rounded="xl" color="bg3">
      <v-card-title d-flex class="justify-space-between">
        <v-icon large left>
          mdi-apple
        </v-icon>
        <v-icon>
          mdi-bookmark-outline
        </v-icon>
      </v-card-title>

      <v-card-text class="title">
        {{ title }}
        <img src="https://i.imgur.com/AmSAypX.jpg" :alt=thumbnail />
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
import { Vue, Component, Prop } from "vue-property-decorator";

@Component
export default class PublicArticle extends Vue {
  @Prop(String) readonly title: string | undefined;
  @Prop(String) readonly url: string | undefined;
  @Prop(String) readonly thumbnail: string | undefined;

  // method
  Direct(): void {
    if (this.url) {
      window.open(this.url);
    }
  }
}
</script>

<style>
.article {
  margin: 15px;
}

.title{
  display: flex;
  flex-direction: column;
}

.title img{
  object-fit: cover;
  width: 100%;
  height: 100%;
}
</style>


