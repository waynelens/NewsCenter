<template>
  <div class="article-container" @click="Direct">
    <v-card rounded="xl" color="bg3" class="article">
      <v-card-title d-flex class="justify-space-between">
        <img :src="news.logo" alt="Logo" class="article-logo" />
        <v-icon>
          mdi-bookmark-outline
        </v-icon>
      </v-card-title>

      <v-card-text class="title">
        <p>{{ news.title }}</p>
        <p>{{ pubUtcDate }}</p>
        <img src="https://i.imgur.com/AmSAypX.jpg" :alt="news.thumbnail" />
      </v-card-text>

      <v-card-actions>
        <v-icon class="mr-1">
          mdi-thumb-up-outline
        </v-icon>
        <span class="subheading mr-2">{{ news.upvoteCount }}</span>
        <span class="mr-1">·</span>
        <v-icon class="mr-1">
          mdi-comment-processing-outline
        </v-icon>
        <span class="subheading">{{ news.commentCount }}</span>
      </v-card-actions>
    </v-card>
  </div>
</template>

<script lang="ts">
import { Vue, Component, Prop } from "vue-property-decorator";
import { INewsModel } from "../../viewmodel/INewsModel";

@Component
export default class PublicArticle extends Vue {
  @Prop(String) readonly news!: INewsModel;
  // method
  Direct(): void {
    if (this.news.url) {
      window.open(this.news.url);
    }
  }
  //computed
  get pubUtcDate(): string {
    return new Date(this.news.pubDate).toUTCString();
  }
}
</script>

<style>
.article-container {
  margin: 15px;
  width: calc((100%-30px) / 6);
}

.article {
  width: 100%;
  padding: 5px;
}

.title {
  display: flex;
  flex-direction: column;
  text-overflow: ellipsis;
}

.title img {
  object-fit: cover;
  width: 100%;
  height: 100%;
}

.title p:first-child {
  font-size: 18px;
  overflow: hidden;
  text-overflow: ellipsis;
  display: -webkit-box;
  -webkit-line-clamp: 2;
  -webkit-box-orient: vertical;
  color: #000;
  font-weight: 400;
}

.title p:nth-child(2){
  font-size: 16px;
  font-weight: 900;
}

.article-logo {
  width: 30px;
}
</style>


