import Vue from "vue";
import Vuetify from "vuetify/lib";
import ColorChip from './colorchip';

Vue.use(Vuetify);

export default new Vuetify({
   theme:{
       themes:{
           light: ColorChip.lightThemeColor,
           dark: ColorChip.darkThemeColor
       },
   }
});
