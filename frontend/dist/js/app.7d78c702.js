(function(t){function e(e){for(var i,o,c=e[0],s=e[1],l=e[2],v=0,d=[];v<c.length;v++)o=c[v],Object.prototype.hasOwnProperty.call(n,o)&&n[o]&&d.push(n[o][0]),n[o]=0;for(i in s)Object.prototype.hasOwnProperty.call(s,i)&&(t[i]=s[i]);u&&u(e);while(d.length)d.shift()();return r.push.apply(r,l||[]),a()}function a(){for(var t,e=0;e<r.length;e++){for(var a=r[e],i=!0,c=1;c<a.length;c++){var s=a[c];0!==n[s]&&(i=!1)}i&&(r.splice(e--,1),t=o(o.s=a[0]))}return t}var i={},n={app:0},r=[];function o(e){if(i[e])return i[e].exports;var a=i[e]={i:e,l:!1,exports:{}};return t[e].call(a.exports,a,a.exports,o),a.l=!0,a.exports}o.m=t,o.c=i,o.d=function(t,e,a){o.o(t,e)||Object.defineProperty(t,e,{enumerable:!0,get:a})},o.r=function(t){"undefined"!==typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(t,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(t,"__esModule",{value:!0})},o.t=function(t,e){if(1&e&&(t=o(t)),8&e)return t;if(4&e&&"object"===typeof t&&t&&t.__esModule)return t;var a=Object.create(null);if(o.r(a),Object.defineProperty(a,"default",{enumerable:!0,value:t}),2&e&&"string"!=typeof t)for(var i in t)o.d(a,i,function(e){return t[e]}.bind(null,i));return a},o.n=function(t){var e=t&&t.__esModule?function(){return t["default"]}:function(){return t};return o.d(e,"a",e),e},o.o=function(t,e){return Object.prototype.hasOwnProperty.call(t,e)},o.p="";var c=window["webpackJsonp"]=window["webpackJsonp"]||[],s=c.push.bind(c);c.push=e,c=c.slice();for(var l=0;l<c.length;l++)e(c[l]);var u=s;r.push([0,"chunk-vendors"]),a()})({0:function(t,e,a){t.exports=a("cd49")},"04cb":function(t,e,a){"use strict";var i=a("66a6"),n=a.n(i);n.a},"33af":function(t,e,a){},"38fe":function(t,e,a){"use strict";var i=a("c66f"),n=a.n(i);n.a},"5ced":function(t,e,a){},"66a6":function(t,e,a){},a63e:function(t,e,a){"use strict";var i=a("33af"),n=a.n(i);n.a},c66f:function(t,e,a){},cccb:function(t,e,a){"use strict";var i=a("5ced"),n=a.n(i);n.a},cd49:function(t,e,a){"use strict";a.r(e);a("e260"),a("e6cf"),a("cca6"),a("a79d");var i=a("2b0e"),n=function(){var t=this,e=t.$createElement,a=t._self._c||e;return a("v-app",[a("v-app-bar",{attrs:{app:"",flat:"",color:"bg1"}},[a("PublicHeader")],1),a("v-navigation-drawer",{attrs:{"expand-on-hover":"",app:"","mini-variant":"","mini-variant-width":"1",color:"bg3"}},[a("PublicNavDrawer")],1),a("v-main",[a("router-view")],1)],1)},r=[],o=a("d4ec"),c=a("262e"),s=a("2caf"),l=a("9ab4"),u=a("60a3"),v=function(t){Object(c["a"])(a,t);var e=Object(s["a"])(a);function a(){return Object(o["a"])(this,a),e.apply(this,arguments)}return a}(u["b"]);v=Object(l["a"])([u["a"]],v);var d=v,h=d,f=a("2877"),b=a("6544"),m=a.n(b),p=function(){var t=this,e=t.$createElement,a=t._self._c||e;return a("div",{staticClass:"publicheader"},[a("div",{attrs:{id:"logo"},on:{click:t.directToHome}},[a("svg",{attrs:{height:"20",viewBox:"0 0 114 20",width:"114",xmlns:"http://www.w3.org/2000/svg"}},[a("g",{attrs:{fill:"var(--theme-primary)","fill-rule":"evenodd"}},[a("g",{attrs:{"fill-rule":"nonzero"}},[a("path",{attrs:{d:"m30.6275981 9.99305809-3.9372132-3.94545631 1.9675807-3.94408558 6.397202 6.41059547c.815093.81679956.815093 2.14109333 0 2.95789283l-7.8737425 7.8902273c-.815093.8167995-2.1366199.8167995-2.951713 0-.815093-.8167996-.815093-2.1410933 0-2.9578929z",opacity:".56"}}),a("path",{attrs:{d:"m24.2311793.61615139c.815093-.81679956 2.1369619-.81645687 2.9520549.00034268l1.4761985 1.47928911-17.2226575 17.25871552c-.815093.8167996-2.13696189.8164569-2.95205494-.0003426l-1.47619847-1.4792891zm-7.3813344 5.42440273-2.9523969 2.95857821-3.93721319-3.94545631-4.92134551 4.93164905 3.93721319 3.94545633-1.9675807 3.9440856-6.39720201-6.4105955c-.81509304-.8167996-.81509304-2.1410933 0-2.95789286l7.87340048-7.88988457c.81509305-.81679955 2.13696194-.81714224 2.95205494-.00034268z"}})]),a("path",{attrs:{d:"m44.4315566 6.7759283v6.7014676h3.6810487l.7802045 2.2338223h-4.4612532c-1.2295036 0-2.2262132-1.0001164-2.2262132-2.2338225v-6.7014674c0-1.23370611.9967096-2.23382252 2.2262132-2.23382252h3.6810487v2.23382252h.7802045v-4.46764503c0-.61685306.4990134-1.11691126 1.1145777-1.11691126h1.1145777v13.40293499c0 .616853-.4990134 1.1169112-1.1145777 1.1169112h-1.1145777v-8.9352899zm11.1457879 8.9353101c-1.2295029 0-2.2262238-1.0001225-2.2262238-2.233828v-2.2338371c0-1.2337061.9967096-2.23382248 2.2262132-2.23382248h3.6810487v2.23382248h.7802045v-4.467645h-6.1309131l.0000016-1.11691126c0-.6168524.4983538-1.11691126 1.113105-1.11691126h5.0178065c1.2311285 0 2.2291654 1.00011641 2.2291654 2.23382252v7.8183989c0 .616853-.4990134 1.1169112-1.1145777 1.1169112h-1.1145877v-4.4676651h-4.4612532v2.2338226h3.6810487l.7802045 2.2338425c-2.7480959 0-4.2351768 0-4.4612426 0zm8.9195535-.00002v-10.05220136c0-.61685305.4983548-1.11691126 1.1131066-1.11691126h1.1131066v10.05220132c0 .6168531-.4983548 1.1169113-1.1131066 1.1169113zm2.2262132-13.39563506c0 .31147136-.106702.57427138-.3201091.78840795-.2134071.21413656-.4753119.32120324-.7857223.32120324s-.5747402-.10706668-.7929975-.32120324c-.2182573-.21413657-.3273843-.47693659-.3273843-.78840795 0-.32120484.109127-.58887153.3273843-.80300809.2182573-.21413657.4825871-.32120324.7929975-.32120324s.5723152.10706667.7857223.32120324c.2134071.21413656.3201091.48180325.3201091.80300809zm2.2320977 13.39563506v-13.40293513c0-.61685306.4983548-1.11691126 1.1131066-1.11691126h1.1131066v13.40293509c0 .6168531-.4983548 1.1169113-1.1131066 1.1169113zm7.5120792.0044843-3.0055197-9.45238287c-.179736-.58989951.158877-1.21431042.7467671-1.3946608l1.0588488-.32655325 2.4520711 8.02770052 2.2068639-7.23704629c.179736-.58989951.7941863-.92190468 1.3820763-.7415543l1.0217461.32655325-3.7858988 12.56307184c-.2861391.9391179-1.1501609 1.5805839-2.1288435 1.580716l-1.8403746.0004053c-.6147518 0-1.1131736-.4999079-1.1132564-1.1167609l.0001498-1.1170616h1.8500493c.6130072 0 1.1528594-.4973293 1.1553206-1.1124269z"}}),a("path",{attrs:{d:"m85.9618959 15.8565941v-1.5782842h-1.6191453v1.5782842zm4.8427164.1032523c.7850401 0 1.449871-.196671 1.9944926-.5900129.5446216-.3933418.9248754-.9194366 1.1407615-1.5782842v2.0650448h1.3394747v-10.91523687h-1.3394747v4.88235596c-.2158861-.65884763-.5961399-1.18494238-1.1407615-1.57828425s-1.2094525-.59001281-1.9944926-.59001281c-.7163492 0-1.3541943.1671703-1.9135354.50151089s-.9984729.81618438-1.3173955 1.44553137c-.3189225.62934701-.4783838 1.36686301-.4783838 2.21254801s.1594613 1.5807426.4783838 2.2051729c.3189226.6244302.7580544 1.1038156 1.3173955 1.4381562s1.1971862.5015109 1.9135354.5015109zm.382707-1.1800257c-.8242921 0-1.4842165-.2630473-1.9797731-.7891421-.4955566-.5260947-.7433349-1.2513188-.7433349-2.1756722s.2477783-1.6495775.7433349-2.17567221c.4955566-.52609475 1.155481-.78914213 1.9797731-.78914213.5299021 0 1.0033795.12046095 1.4204321.36138284.4170525.2409219.7433348.58755442.9788469 1.0398976.235512.4523431.3532681.9735211.3532681 1.5635339s-.1177561 1.1087324-.3532681 1.5561588c-.2355121.4474263-.5617944.7940589-.9788469 1.0398975-.4170526.2458387-.89053.368758-1.4204321.368758zm9.8031887 1.1800257c.677097 0 1.285503-.1229194 1.825218-.3687581.539716-.2458386.978847-.5900128 1.317396-1.0325224s.556888-.9440204.655018-1.5045326h-1.427792c-.09813.5506786-.365534.9907298-.802213 1.3201536-.436678.3294239-.978847.4941358-1.626505.4941358-.716349 0-1.3223018-.2310884-1.8178584-.6932651s-.7580544-1.1554417-.7874934-2.0797951h6.4618618c.039252-.2065045.058878-.4523432.058878-.737516 0-.6785147-.154555-1.2980282-.463664-1.85854035-.30911-.56051217-.755602-1.00793854-1.339475-1.34227913-.583874-.33434059-1.268331-.50151089-2.053371-.50151089-.775227 0-1.4621371.1671703-2.0607302.50151089s-1.067164.81618438-1.4057125 1.44553137c-.3385486.62934701-.5078229 1.36686301-.5078229 2.21254801s.1692743 1.5807426.5078229 2.2051729c.3385485.6244302.8071194 1.1038156 1.4057125 1.4381562s1.2855032.5015109 2.0607302.5015109zm2.502316-4.513598h-5.1665458c.039252-.8850192.3091095-1.55615877.8095726-2.01341869.5004631-.45725993 1.1186822-.68588989 1.8546572-.68588989.461211 0 .888077.09833547 1.280597.2950064.39252.19667094.70163.49659411.927329.89976953.225699.40317545.323829.90468625.29439 1.50453265zm7.021202 4.4103457 3.164694-8.09792573h-1.442512l-2.502315 6.66714473-2.531755-6.66714473h-1.442511l3.164693 8.09792573z","fill-rule":"nonzero",opacity:".56"}})])])]),a("div",{attrs:{id:"bookmark-switch"}},[a("v-switch",{attrs:{label:t.bookMarkLabel,color:"orange","hide-details":""},model:{value:t.bookMarkStatus,callback:function(e){t.bookMarkStatus=e},expression:"bookMarkStatus"}})],1),a("div",{attrs:{id:"functional-button-group"}},[a("v-menu",{attrs:{"offset-y":""},scopedSlots:t._u([{key:"activator",fn:function(e){var i=e.on,n=e.attrs;return[a("v-btn",t._g(t._b({staticClass:"mx-2",attrs:{fab:"",small:"",icon:""}},"v-btn",n,!1),i),[a("v-icon",[t._v(" mdi-weather-night ")])],1)]}}])},[a("v-list",t._l(t.disturbs,(function(e,i){return a("v-list-item",{key:i,attrs:{link:""}},[a("v-list-item-title",{on:{click:function(a){return t.switchDisturbStatus(e)}}},[t._v(t._s(e))])],1)})),1)],1),a("v-dialog",{attrs:{width:"20%"},scopedSlots:t._u([{key:"activator",fn:function(e){var i=e.on,n=e.attrs;return[a("v-btn",t._g(t._b({attrs:{icon:""}},"v-btn",n,!1),i),[a("v-icon",[t._v("mdi-console")])],1)]}}]),model:{value:t.consoledialog,callback:function(e){t.consoledialog=e},expression:"consoledialog"}},[a("v-card",[a("v-card-title",{staticClass:"subtitle-1"},[t._l(t.consoleBtn,(function(e,i){return a("v-icon",{key:i,attrs:{"x-small":"",color:e}},[t._v(" mdi-circle ")])})),a("p",[t._v("Terminal")])],2),a("v-card-text",[t._v(" Lorem ipsum dolor sit amet consectetur adipisicing elit. Reprehenderit eaque expedita incidunt earum, veritatis non quo error laudantium deleniti alias fugit dolore voluptate aliquam consequuntur recusandae eveniet unde iure ratione. Ipsam eaque repellat ipsa sed voluptatibus in excepturi explicabo odio, amet rerum! Ducimus labore ex id illum vero blanditiis maiores! ")])],1)],1),a("v-btn",{attrs:{icon:""},on:{click:t.switchLayoutStatus}},[a("v-icon",[t._v(" mdi-table ")])],1),a("v-dialog",{attrs:{width:"20%"},scopedSlots:t._u([{key:"activator",fn:function(e){var i=e.on,n=e.attrs;return[a("v-btn",t._g(t._b({attrs:{id:"sign-in-btn"}},"v-btn",n,!1),i),[a("v-icon",[t._v("mdi-account")]),t._v(" Sign in ")],1)]}}]),model:{value:t.logindialog,callback:function(e){t.logindialog=e},expression:"logindialog"}},[a("v-card",[a("v-card-title",[a("svg",{attrs:{height:"20",viewBox:"0 0 114 20",width:"114",xmlns:"http://www.w3.org/2000/svg"}},[a("g",{attrs:{fill:"var(--theme-primary)","fill-rule":"evenodd"}},[a("g",{attrs:{"fill-rule":"nonzero"}},[a("path",{attrs:{d:"m30.6275981 9.99305809-3.9372132-3.94545631 1.9675807-3.94408558 6.397202 6.41059547c.815093.81679956.815093 2.14109333 0 2.95789283l-7.8737425 7.8902273c-.815093.8167995-2.1366199.8167995-2.951713 0-.815093-.8167996-.815093-2.1410933 0-2.9578929z",opacity:".56"}}),a("path",{attrs:{d:"m24.2311793.61615139c.815093-.81679956 2.1369619-.81645687 2.9520549.00034268l1.4761985 1.47928911-17.2226575 17.25871552c-.815093.8167996-2.13696189.8164569-2.95205494-.0003426l-1.47619847-1.4792891zm-7.3813344 5.42440273-2.9523969 2.95857821-3.93721319-3.94545631-4.92134551 4.93164905 3.93721319 3.94545633-1.9675807 3.9440856-6.39720201-6.4105955c-.81509304-.8167996-.81509304-2.1410933 0-2.95789286l7.87340048-7.88988457c.81509305-.81679955 2.13696194-.81714224 2.95205494-.00034268z"}})]),a("path",{attrs:{d:"m44.4315566 6.7759283v6.7014676h3.6810487l.7802045 2.2338223h-4.4612532c-1.2295036 0-2.2262132-1.0001164-2.2262132-2.2338225v-6.7014674c0-1.23370611.9967096-2.23382252 2.2262132-2.23382252h3.6810487v2.23382252h.7802045v-4.46764503c0-.61685306.4990134-1.11691126 1.1145777-1.11691126h1.1145777v13.40293499c0 .616853-.4990134 1.1169112-1.1145777 1.1169112h-1.1145777v-8.9352899zm11.1457879 8.9353101c-1.2295029 0-2.2262238-1.0001225-2.2262238-2.233828v-2.2338371c0-1.2337061.9967096-2.23382248 2.2262132-2.23382248h3.6810487v2.23382248h.7802045v-4.467645h-6.1309131l.0000016-1.11691126c0-.6168524.4983538-1.11691126 1.113105-1.11691126h5.0178065c1.2311285 0 2.2291654 1.00011641 2.2291654 2.23382252v7.8183989c0 .616853-.4990134 1.1169112-1.1145777 1.1169112h-1.1145877v-4.4676651h-4.4612532v2.2338226h3.6810487l.7802045 2.2338425c-2.7480959 0-4.2351768 0-4.4612426 0zm8.9195535-.00002v-10.05220136c0-.61685305.4983548-1.11691126 1.1131066-1.11691126h1.1131066v10.05220132c0 .6168531-.4983548 1.1169113-1.1131066 1.1169113zm2.2262132-13.39563506c0 .31147136-.106702.57427138-.3201091.78840795-.2134071.21413656-.4753119.32120324-.7857223.32120324s-.5747402-.10706668-.7929975-.32120324c-.2182573-.21413657-.3273843-.47693659-.3273843-.78840795 0-.32120484.109127-.58887153.3273843-.80300809.2182573-.21413657.4825871-.32120324.7929975-.32120324s.5723152.10706667.7857223.32120324c.2134071.21413656.3201091.48180325.3201091.80300809zm2.2320977 13.39563506v-13.40293513c0-.61685306.4983548-1.11691126 1.1131066-1.11691126h1.1131066v13.40293509c0 .6168531-.4983548 1.1169113-1.1131066 1.1169113zm7.5120792.0044843-3.0055197-9.45238287c-.179736-.58989951.158877-1.21431042.7467671-1.3946608l1.0588488-.32655325 2.4520711 8.02770052 2.2068639-7.23704629c.179736-.58989951.7941863-.92190468 1.3820763-.7415543l1.0217461.32655325-3.7858988 12.56307184c-.2861391.9391179-1.1501609 1.5805839-2.1288435 1.580716l-1.8403746.0004053c-.6147518 0-1.1131736-.4999079-1.1132564-1.1167609l.0001498-1.1170616h1.8500493c.6130072 0 1.1528594-.4973293 1.1553206-1.1124269z"}}),a("path",{attrs:{d:"m85.9618959 15.8565941v-1.5782842h-1.6191453v1.5782842zm4.8427164.1032523c.7850401 0 1.449871-.196671 1.9944926-.5900129.5446216-.3933418.9248754-.9194366 1.1407615-1.5782842v2.0650448h1.3394747v-10.91523687h-1.3394747v4.88235596c-.2158861-.65884763-.5961399-1.18494238-1.1407615-1.57828425s-1.2094525-.59001281-1.9944926-.59001281c-.7163492 0-1.3541943.1671703-1.9135354.50151089s-.9984729.81618438-1.3173955 1.44553137c-.3189225.62934701-.4783838 1.36686301-.4783838 2.21254801s.1594613 1.5807426.4783838 2.2051729c.3189226.6244302.7580544 1.1038156 1.3173955 1.4381562s1.1971862.5015109 1.9135354.5015109zm.382707-1.1800257c-.8242921 0-1.4842165-.2630473-1.9797731-.7891421-.4955566-.5260947-.7433349-1.2513188-.7433349-2.1756722s.2477783-1.6495775.7433349-2.17567221c.4955566-.52609475 1.155481-.78914213 1.9797731-.78914213.5299021 0 1.0033795.12046095 1.4204321.36138284.4170525.2409219.7433348.58755442.9788469 1.0398976.235512.4523431.3532681.9735211.3532681 1.5635339s-.1177561 1.1087324-.3532681 1.5561588c-.2355121.4474263-.5617944.7940589-.9788469 1.0398975-.4170526.2458387-.89053.368758-1.4204321.368758zm9.8031887 1.1800257c.677097 0 1.285503-.1229194 1.825218-.3687581.539716-.2458386.978847-.5900128 1.317396-1.0325224s.556888-.9440204.655018-1.5045326h-1.427792c-.09813.5506786-.365534.9907298-.802213 1.3201536-.436678.3294239-.978847.4941358-1.626505.4941358-.716349 0-1.3223018-.2310884-1.8178584-.6932651s-.7580544-1.1554417-.7874934-2.0797951h6.4618618c.039252-.2065045.058878-.4523432.058878-.737516 0-.6785147-.154555-1.2980282-.463664-1.85854035-.30911-.56051217-.755602-1.00793854-1.339475-1.34227913-.583874-.33434059-1.268331-.50151089-2.053371-.50151089-.775227 0-1.4621371.1671703-2.0607302.50151089s-1.067164.81618438-1.4057125 1.44553137c-.3385486.62934701-.5078229 1.36686301-.5078229 2.21254801s.1692743 1.5807426.5078229 2.2051729c.3385485.6244302.8071194 1.1038156 1.4057125 1.4381562s1.2855032.5015109 2.0607302.5015109zm2.502316-4.513598h-5.1665458c.039252-.8850192.3091095-1.55615877.8095726-2.01341869.5004631-.45725993 1.1186822-.68588989 1.8546572-.68588989.461211 0 .888077.09833547 1.280597.2950064.39252.19667094.70163.49659411.927329.89976953.225699.40317545.323829.90468625.29439 1.50453265zm7.021202 4.4103457 3.164694-8.09792573h-1.442512l-2.502315 6.66714473-2.531755-6.66714473h-1.442511l3.164693 8.09792573z","fill-rule":"nonzero",opacity:".56"}})])]),a("div",{staticClass:"headline"},[t._v("SIGN IN TO DAILY")])]),a("v-card-text",[a("div",[a("v-icon",[t._v(" mdi-link-variant ")]),a("p",[t._v("Influence content by requesting sources & articles")])],1),a("div",[a("v-icon",[t._v(" mdi-cloud-upload-outline ")]),a("p",[t._v("Sync settings and bookmarks across devices & browsers")])],1),a("div",[a("v-icon",[t._v(" mdi-account-group-outline ")]),a("p",[t._v("Help the community by moderating irrelevant content")])],1)]),a("v-card-actions",[a("v-spacer"),a("v-btn",{attrs:{icon:""},on:{click:function(e){t.logindialog=!1}}},[a("v-icon",[t._v(" mdi-github ")])],1),a("v-btn",{attrs:{icon:""},on:{click:function(e){t.logindialog=!1}}},[a("v-icon",[t._v(" mdi-google ")])],1)],1)],1)],1)],1)])},g=[],k=a("bee2"),y=function(t){Object(c["a"])(a,t);var e=Object(s["a"])(a);function a(){var t;return Object(o["a"])(this,a),t=e.apply(this,arguments),t.disturbs=["For One Hour","Until Tomorrow","Forever","Turn Off"],t.consoledialog=!1,t.logindialog=!1,t.consoleBtn=["red","orange","green"],t}return Object(k["a"])(a,[{key:"directToHome",value:function(){document.location.href="/"}},{key:"switchDisturbStatus",value:function(t){this.$store.commit("switchDisturbStatus",t)}},{key:"switchLayoutStatus",value:function(){this.$store.commit("switchLayoutPanelStatus")}},{key:"bookMarkLabel",get:function(){return this.$store.state.bookMarkStatus?"BookMark":"Feed"}},{key:"bookMarkStatus",set:function(t){this.$store.commit("switchBookMarkStatus",t)}}]),a}(u["b"]);y=Object(l["a"])([u["a"]],y);var w=y,_=w,S=(a("d02f"),a("8336")),C=a("b0af"),O=a("99d9"),x=a("169a"),j=a("132d"),T=a("8860"),V=a("da13"),L=a("5d23"),z=a("e449"),P=a("2fa4"),A=a("b73d"),I=Object(f["a"])(_,p,g,!1,null,null,null),D=I.exports;m()(I,{VBtn:S["a"],VCard:C["a"],VCardActions:O["a"],VCardText:O["b"],VCardTitle:O["c"],VDialog:x["a"],VIcon:j["a"],VList:T["a"],VListItem:V["a"],VListItemTitle:L["b"],VMenu:z["a"],VSpacer:P["a"],VSwitch:A["a"]});var $=function(){var t=this,e=t.$createElement,a=t._self._c||e;return a("div",{staticClass:"publicnav"},[a("div",{attrs:{id:"link-tag-switch"}},[a("v-switch",{attrs:{inset:"",label:t.linkTagListStatus},model:{value:t.linkTagSwitch,callback:function(e){t.linkTagSwitch=e},expression:"linkTagSwitch"}})],1),a("div",{attrs:{id:"add-source"}},[a("v-btn",{attrs:{id:"addsourcebtn"},on:{click:function(e){t.addSourceDialog=!0}}},[t._v(" + Add New Source ")]),a("v-dialog",{attrs:{width:"20%"},model:{value:t.addSourceDialog,callback:function(e){t.addSourceDialog=e},expression:"addSourceDialog"}},[a("v-card",[a("v-card-title",[t._v(" Add New Source ")]),a("v-card-text",[a("p",[t._v(" Have an idea for a new source? Insert its link below to add it to your feed. ")]),a("v-text-field",{attrs:{value:"",filled:"",autofocus:"",placeholder:"Past Blog Rss URL"}})],1),a("v-card-actions",[a("v-btn",{on:{click:function(e){t.addSourceDialog=!1}}},[t._v(" Ok ")])],1)],1)],1)],1),a("CoreLinkList"),a("div",{attrs:{id:"test"}},[a("v-text-field",{attrs:{placeholder:"Search Source","prepend-inner-icon":"mdi-magnify",filled:""}})],1)],1)},M=[],E=function(t){Object(c["a"])(a,t);var e=Object(s["a"])(a);function a(){var t;return Object(o["a"])(this,a),t=e.apply(this,arguments),t.linkTagSwitch=!1,t.addSourceDialog=!1,t}return Object(k["a"])(a,[{key:"switchlinkTagListStatus",value:function(t,e){t?this.$store.commit("switchlinkTagListStatus","Tag"):this.$store.commit("switchlinkTagListStatus","Link")}},{key:"linkTagListStatus",get:function(){return this.$store.state.linkTagListStatus}}]),a}(u["b"]);Object(l["a"])([Object(u["c"])("linkTagSwitch")],E.prototype,"switchlinkTagListStatus",null),E=Object(l["a"])([u["a"]],E);var N=E,B=N,R=(a("a63e"),function(){var t=this,e=t.$createElement,a=t._self._c||e;return a("div",{staticClass:"linklist"},[a("v-list",{attrs:{flat:""}},[a("v-subheader",[t._v("MY PUBLIC SOURCES")]),a("v-list-item-group",t._l(t.linkGroup,(function(e,i){return a("v-list-item",{key:i},[a("v-list-item-icon",[a("v-icon",[t._v(" "+t._s(e.icon)+" ")])],1),a("v-list-item-content",[a("v-list-item-title",[t._v(t._s(e.title))])],1)],1)})),1)],1)],1)}),q=[],H=function(t){Object(c["a"])(a,t);var e=Object(s["a"])(a);function a(){var t;return Object(o["a"])(this,a),t=e.apply(this,arguments),t.linkGroup=[{title:"80 Level",icon:"mdi-clock"},{title:"Hacker News",icon:"mdi-flag"}],t}return a}(u["b"]);H=Object(l["a"])([u["a"]],H);var G=H,F=G,U=a("1baa"),Y=a("34c3"),J=a("e0c7"),K=Object(f["a"])(F,R,q,!1,null,null,null),Q=K.exports;m()(K,{VIcon:j["a"],VList:T["a"],VListItem:V["a"],VListItemContent:L["a"],VListItemGroup:U["a"],VListItemIcon:Y["a"],VListItemTitle:L["b"],VSubheader:J["a"]});var W=a("8654"),X=Object(f["a"])(B,$,M,!1,null,null,null),Z=X.exports;m()(X,{CoreLinkList:Q,VBtn:S["a"],VCard:C["a"],VCardActions:O["a"],VCardText:O["b"],VCardTitle:O["c"],VDialog:x["a"],VSwitch:A["a"],VTextField:W["a"]});var tt=a("7496"),et=a("40dc"),at=a("f6c4"),it=a("f774"),nt=Object(f["a"])(h,n,r,!1,null,null,null),rt=nt.exports;m()(nt,{PublicHeader:D,PublicNavDrawer:Z,VApp:tt["a"],VAppBar:et["a"],VMain:at["a"],VNavigationDrawer:it["a"]});var ot=a("9483");Object(ot["a"])("".concat("","service-worker.js"),{ready:function(){console.log("App is being served from cache by a service worker.\nFor more details, visit https://goo.gl/AFskqB")},registered:function(){console.log("Service worker has been registered.")},cached:function(){console.log("Content has been cached for offline use.")},updatefound:function(){console.log("New content is downloading.")},updated:function(){console.log("New content is available; please refresh.")},offline:function(){console.log("No internet connection found. App is running in offline mode.")},error:function(t){console.error("Error during service worker registration:",t)}});var ct=a("8c4f"),st=function(){var t=this,e=t.$createElement,a=t._self._c||e;return a("div",{staticClass:"home"},[a("div",{style:t.bg1Color,attrs:{id:"side-line-number"}},[a("v-icon",[t._v(" mdi-menu ")]),t._l(50,(function(e,i){return a("span",{key:i},[t._v(t._s(i))])}))],2),a("div",{style:t.bg1Color,attrs:{id:"main-content"}},[a("CoreLayoutPanel",{attrs:{color:"bg2"}}),a("div",{attrs:{id:"bread"}},[a("div",{attrs:{id:"search-article"}},[a("v-text-field",{attrs:{"prepend-inner-icon":"mdi-magnify",placeholder:"Search"}})],1),a("div",{attrs:{id:"time-button"}},[a("v-dialog",{attrs:{width:"500"},scopedSlots:t._u([{key:"activator",fn:function(e){var i=e.on,n=e.attrs;return[a("v-btn",t._g(t._b({attrs:{icon:""}},"v-btn",n,!1),i),[a("v-icon",[t._v("mdi-flash")])],1)]}}]),model:{value:t.dialog,callback:function(e){t.dialog=e},expression:"dialog"}},[a("v-card",[a("v-card-title",{staticClass:"headline grey lighten-2"},[t._v(" Privacy Policy ")]),a("v-card-text",[t._v(" Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. ")]),a("v-divider"),a("v-card-actions",[a("v-spacer"),a("v-btn",{attrs:{color:"primary",text:""},on:{click:function(e){t.dialog=!1}}},[t._v(" I accept ")])],1)],1)],1),a("v-btn",{attrs:{icon:""}},[t._v("POPLUAR")]),a("v-btn",{attrs:{icon:""}},[t._v("RECENT")])],1)]),a("div",{attrs:{id:"articles"}},[a("CoreArticle"),a("CoreArticle"),a("CoreArticle"),a("CoreArticle"),a("CoreArticle"),a("CoreArticle"),a("CoreArticle"),a("CoreArticle"),a("CoreArticle")],1)],1)])},lt=[],ut=function(t){Object(c["a"])(a,t);var e=Object(s["a"])(a);function a(){return Object(o["a"])(this,a),e.apply(this,arguments)}return Object(k["a"])(a,[{key:"themeStatus",get:function(){return this.$store.state.themeStatus}},{key:"bg1Color",get:function(){var t="background-color:";return this.themeStatus?t+this.$vuetify.theme.themes.light.bg1:t+this.$vuetify.theme.themes.dark.bg1}}]),a}(u["b"]);ut=Object(l["a"])([u["a"]],ut);var vt=ut,dt=vt,ht=(a("cccb"),function(){var t=this,e=t.$createElement,a=t._self._c||e;return a("div",{staticClass:"article"},[a("v-card",{attrs:{"max-width":"300",rounded:"xl",color:"bg3"}},[a("v-card-title",{staticClass:"justify-space-between",attrs:{"d-flex":""}},[a("v-icon",{attrs:{large:"",left:""}},[t._v(" mdi-twitter ")]),a("span",{staticClass:"title"},[t._v("Twitter")]),a("v-icon",[t._v(" mdi-bookmark-outline ")])],1),a("v-card-text",{staticClass:"title"},[t._v(' "Turns out semicolon-less style is easier and safer in TS because most gotcha edge cases are type invalid as well." ')]),a("v-card-actions",[a("v-icon",{staticClass:"mr-1"},[t._v(" mdi-thumb-up-outline ")]),a("span",{staticClass:"subheading mr-2"},[t._v("256")]),a("span",{staticClass:"mr-1"},[t._v("·")]),a("v-icon",{staticClass:"mr-1"},[t._v(" mdi-comment-processing-outline ")]),a("span",{staticClass:"subheading"},[t._v("45")])],1)],1)],1)}),ft=[],bt=function(t){Object(c["a"])(a,t);var e=Object(s["a"])(a);function a(){return Object(o["a"])(this,a),e.apply(this,arguments)}return a}(u["b"]);bt=Object(l["a"])([u["a"]],bt);var mt=bt,pt=mt,gt=(a("04cb"),Object(f["a"])(pt,ht,ft,!1,null,null,null)),kt=gt.exports;m()(gt,{VCard:C["a"],VCardActions:O["a"],VCardText:O["b"],VCardTitle:O["c"],VIcon:j["a"]});var yt=function(){var t=this,e=t.$createElement,a=t._self._c||e;return a("v-toolbar",{attrs:{color:"bg2",flat:"",extended:"","extension-height":"100"}},[a("div",{attrs:{id:"options"}},[a("div",{staticClass:"option"},[a("p",[t._v("LAYOUT")]),a("v-switch",{attrs:{label:"test"},model:{value:t.layout,callback:function(e){t.layout=e},expression:"layout"}})],1),a("div",{staticClass:"option"},[a("p",[t._v("DENSITY")]),a("v-radio-group",{model:{value:t.radioGroup,callback:function(e){t.radioGroup=e},expression:"radioGroup"}},t._l(3,(function(t){return a("v-radio",{key:t,attrs:{label:"Radio "+t,value:t}})})),1)],1),a("div",{staticClass:"option"},[a("p",[t._v("PREFERENCE")]),a("div",{attrs:{id:"switch-group"}},[a("v-switch",{attrs:{label:"Light Theme"},model:{value:t.theme,callback:function(e){t.theme=e},expression:"theme"}}),a("v-switch",{attrs:{label:"Hide Read Posts"},model:{value:t.layout2,callback:function(e){t.layout2=e},expression:"layout2"}}),a("v-switch",{attrs:{label:"Recently Visited Sites"},model:{value:t.layout2,callback:function(e){t.layout2=e},expression:"layout2"}}),a("v-switch",{attrs:{label:"Open Link In New Tab"},model:{value:t.layout2,callback:function(e){t.layout2=e},expression:"layout2"}})],1)])])])},wt=[],_t=function(t){Object(c["a"])(a,t);var e=Object(s["a"])(a);function a(){var t;return Object(o["a"])(this,a),t=e.apply(this,arguments),t.layout=!1,t}return Object(k["a"])(a,[{key:"theme",get:function(){return this.$store.state.themeStatus},set:function(t){this.$vuetify.theme.dark=!t,this.$store.commit("switchThemeStatus",t)}}]),a}(u["b"]);_t=Object(l["a"])([u["a"]],_t);var St=_t,Ct=St,Ot=(a("38fe"),a("67b6")),xt=a("43a6"),jt=a("71d9"),Tt=Object(f["a"])(Ct,yt,wt,!1,null,null,null),Vt=Tt.exports;m()(Tt,{VRadio:Ot["a"],VRadioGroup:xt["a"],VSwitch:A["a"],VToolbar:jt["a"]});var Lt=a("ce7e"),zt=Object(f["a"])(dt,st,lt,!1,null,null,null),Pt=zt.exports;m()(zt,{CoreArticle:kt,CoreLayoutPanel:Vt,VBtn:S["a"],VCard:C["a"],VCardActions:O["a"],VCardText:O["b"],VCardTitle:O["c"],VDialog:x["a"],VDivider:Lt["a"],VIcon:j["a"],VSpacer:P["a"],VTextField:W["a"]}),i["a"].use(ct["a"]);var At=[{path:"/",name:"Home",component:Pt}],It=new ct["a"]({routes:At}),Dt=It,$t=a("2f62");i["a"].use($t["a"]);var Mt=new $t["a"].Store({state:{bookMarkStatus:!1,disturbStatus:"Turn Off",layoutPanelStatus:!1,linkTagListStatus:"Link",loginStatus:{status:!0,auth:"Github"},themeStatus:!0},mutations:{switchBookMarkStatus:function(t,e){return t.bookMarkStatus=e},switchDisturbStatus:function(t,e){return t.disturbStatus=e},switchLayoutPanelStatus:function(t){return t.layoutPanelStatus=!t.layoutPanelStatus},switchlinkTagListStatus:function(t,e){return t.linkTagListStatus=e},switchThemeStatus:function(t,e){return t.themeStatus=e}},actions:{},modules:{},getters:{}}),Et=a("f309"),Nt={bg1:"#e9eaec",bg2:"#f4f5f6",bg3:"#fff",btnoff:"686e78",btnon:"0076f5"},Bt={bg1:"#151618",bg2:"#1c1e21",bg3:"#25282c",btnoff:"a9abb3",btnon:"0076f5"},Rt={lightThemeColor:Nt,darkThemeColor:Bt};i["a"].use(Et["a"]);var qt=new Et["a"]({theme:{themes:{light:Rt.lightThemeColor,dark:Rt.darkThemeColor}}});i["a"].config.productionTip=!1,new i["a"]({router:Dt,store:Mt,vuetify:qt,render:function(t){return t(rt)}}).$mount("#app")},d02f:function(t,e,a){"use strict";var i=a("f68a"),n=a.n(i);n.a},f68a:function(t,e,a){}});
//# sourceMappingURL=app.7d78c702.js.map