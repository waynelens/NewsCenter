<template>
  <div class="taglist">

    <v-list flat>
      <v-subheader>HOT TAGS</v-subheader>
      <v-list-item-group v-model="tag" color="primary">
        <v-list-item v-for="(item, index) in tagGroup" :key="index">
          <v-list-item-content>
            <v-list-item-title>
                {{item.title}} 
                <v-icon>
                    mdi-minus
                </v-icon>
            </v-list-item-title>
          </v-list-item-content>
        </v-list-item>
      </v-list-item-group>
    </v-list>

  </div>
</template>

<script lang="ts">
import { Vue, Component } from "vue-property-decorator";

@Component
export default class TagList extends Vue {
    tag = 1;
    tagGroup = [
        {title: "#devops",icon: "mdi-clock"},
        {title: "#design",icon: "mdi-flag"},
    ]
}
</script>

<style>
#addLink {
  display: flex;
}
</style>


