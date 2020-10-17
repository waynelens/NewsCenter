<template>
  <v-toolbar color="bg2" flat extended extension-height="100">
    <div id="options">
      <div class="option">
        <p>LAYOUT</p>
        <v-switch v-model="layout" label="test"></v-switch>
      </div>
      <div class="option">
        <p>DENSITY</p>
        <v-radio-group v-model="radioGroup">
          <v-radio
            v-for="n in 3"
            :key="n"
            :label="`Radio ${n}`"
            :value="n"
          ></v-radio>
        </v-radio-group>
      </div>
      <div class="option">
        <p>PREFERENCE</p>
        <div id="switch-group">
          <v-switch v-model="theme" label="Light Theme"></v-switch>
          <v-switch v-model="layout2" label="Hide Read Posts"></v-switch>
          <v-switch v-model="layout2" label="Recently Visited Sites"></v-switch>
          <v-switch v-model="layout2" label="Open Link In New Tab"></v-switch>
        </div>
      </div>
    </div>
  </v-toolbar>
</template>

<script lang="ts">
import { Vue, Component } from "vue-property-decorator";

@Component
export default class CoreLayoutPanel extends Vue {
  layout = false;

  // compute
  get theme():boolean{
    return this.$store.state.themeStatus;
  }
  set theme(value){
    this.$vuetify.theme.dark = !value;
    this.$store.commit('switchThemeStatus',value);
  }
}
</script>

<style>
#options {
  width: 50%;
  height: 150px;
  margin: auto;
  display: flex;
  justify-content: space-around;
}
.option {
  width: 15%;
}
#switch-group {
  display: flex;
  flex-direction: column;
  flex-wrap: wrap;
  height: 120px;
}
</style>


