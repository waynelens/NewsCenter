<template>
  <v-container>
    <v-btn>{{str1}}</v-btn>
  </v-container>
</template>

<script lang="ts">
import { Vue, Component } from "vue-property-decorator";

@Component
export default class CheckFile extends Vue{
   str1 = "死定了";
}
</script>
