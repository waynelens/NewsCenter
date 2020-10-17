import Vue from "vue";
import Vuex from "vuex";

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    bookMarkStatus: false,
    disturbStatus: "Turn Off",
    layoutPanelStatus: false,
    linkTagListStatus: "Link",
    loginStatus:{
      // 測試
      status: true,
      auth: "Github"
    },
    themeStatus: true,
  },
  mutations: {
    switchBookMarkStatus: (state, mode: boolean) => state.bookMarkStatus = mode,
    switchDisturbStatus: (state, mode: string) => state.disturbStatus = mode,
    switchLayoutPanelStatus: (state) => state.layoutPanelStatus = !state.layoutPanelStatus,
    switchlinkTagListStatus: (state,mode:string) => state.linkTagListStatus = mode,
    switchThemeStatus: (state,mode:boolean) => state.themeStatus = mode,
  },
  actions: {},
  modules: {},
  getters: {}
});
