import Vue from "vue";
import Vuex from "vuex";

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    bookMarkStatus: false,
    disturbStatus: "Turn Off",
    layoutPanelStatus: false,
    linkTagListStatus: "Link",
    themeStatus: true,
    sourceStatus: 0,
    latestNewsBatch: 1,
  },
  mutations: {
    switchBookMarkStatus: (state, mode: boolean) => state.bookMarkStatus = mode,
    switchDisturbStatus: (state, mode: string) => state.disturbStatus = mode,
    switchLayoutPanelStatus: (state) => state.layoutPanelStatus = !state.layoutPanelStatus,
    switchlinkTagListStatus: (state, mode: string) => state.linkTagListStatus = mode,
    switchThemeStatus: (state, mode: boolean) => state.themeStatus = mode,
    switchSourceStatus: (state, sourceId: number) => state.sourceStatus = sourceId,
    addLatestNewsBatch: (state, batch: number) => state.latestNewsBatch = batch,
  },
  actions: {},
  modules: {},
  getters: {}
});
