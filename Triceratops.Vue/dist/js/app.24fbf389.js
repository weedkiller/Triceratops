(function(t){function e(e){for(var a,s,c=e[0],i=e[1],l=e[2],p=0,v=[];p<c.length;p++)s=c[p],Object.prototype.hasOwnProperty.call(n,s)&&n[s]&&v.push(n[s][0]),n[s]=0;for(a in i)Object.prototype.hasOwnProperty.call(i,a)&&(t[a]=i[a]);u&&u(e);while(v.length)v.shift()();return o.push.apply(o,l||[]),r()}function r(){for(var t,e=0;e<o.length;e++){for(var r=o[e],a=!0,c=1;c<r.length;c++){var i=r[c];0!==n[i]&&(a=!1)}a&&(o.splice(e--,1),t=s(s.s=r[0]))}return t}var a={},n={app:0},o=[];function s(e){if(a[e])return a[e].exports;var r=a[e]={i:e,l:!1,exports:{}};return t[e].call(r.exports,r,r.exports,s),r.l=!0,r.exports}s.m=t,s.c=a,s.d=function(t,e,r){s.o(t,e)||Object.defineProperty(t,e,{enumerable:!0,get:r})},s.r=function(t){"undefined"!==typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(t,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(t,"__esModule",{value:!0})},s.t=function(t,e){if(1&e&&(t=s(t)),8&e)return t;if(4&e&&"object"===typeof t&&t&&t.__esModule)return t;var r=Object.create(null);if(s.r(r),Object.defineProperty(r,"default",{enumerable:!0,value:t}),2&e&&"string"!=typeof t)for(var a in t)s.d(r,a,function(e){return t[e]}.bind(null,a));return r},s.n=function(t){var e=t&&t.__esModule?function(){return t["default"]}:function(){return t};return s.d(e,"a",e),e},s.o=function(t,e){return Object.prototype.hasOwnProperty.call(t,e)},s.p="/";var c=window["webpackJsonp"]=window["webpackJsonp"]||[],i=c.push.bind(c);c.push=e,c=c.slice();for(var l=0;l<c.length;l++)e(c[l]);var u=i;o.push([0,"chunk-vendors"]),r()})({0:function(t,e,r){t.exports=r("cd49")},cd49:function(t,e,r){"use strict";r.r(e);var a=r("2b0e"),n=function(){var t=this,e=t.$createElement,r=t._self._c||e;return r("layout")},o=[],s=r("d4ec"),c=r("262e"),i=r("2caf"),l=r("9ab4"),u=r("60a3"),p=function(){var t=this,e=t.$createElement,r=t._self._c||e;return r("div",[r("site-navigation"),r("router-view")],1)},v=[],b=function(){var t=this,e=t.$createElement,r=t._self._c||e;return r("nav",{staticClass:"navbar navbar-expand-sm navbar-dark bg-dark",attrs:{id:"site-navigation"}},[r("router-link",{staticClass:"navbar-brand",attrs:{to:"/"}},[t._v("Triceratops")]),t._m(0),r("div",{staticClass:"collapse navbar-collapse",attrs:{id:"navbarSupportedContent"}},[r("ul",{staticClass:"navbar-nav mr-auto"},[r("li",{staticClass:"nav-item"},[r("router-link",{staticClass:"nav-link",attrs:{to:"/servers"}},[t._v("Servers")])],1),r("server-selector")],1)])],1)},f=[function(){var t=this,e=t.$createElement,r=t._self._c||e;return r("button",{staticClass:"navbar-toggler",attrs:{type:"button","data-toggle":"collapse","data-target":"#navbarSupportedContent","aria-controls":"navbarSupportedContent","aria-expanded":"false","aria-label":"Toggle navigation"}},[r("span",{staticClass:"navbar-toggler-icon"})])}],d=function(){var t=this,e=t.$createElement;t._self._c;return t._m(0)},h=[function(){var t=this,e=t.$createElement,r=t._self._c||e;return r("li",{staticClass:"nav-item dropdown"},[r("a",{staticClass:"nav-link dropdown-toggle",attrs:{href:"#",id:"serverSelector",role:"button","data-toggle":"dropdown","aria-haspopup":"true","aria-expanded":"false"}},[t._v("\n        Servers\n    ")]),r("div",{staticClass:"dropdown-menu",attrs:{"aria-labelledby":"serverSelector"}},[r("a",{staticClass:"dropdown-item",attrs:{href:"#"}},[t._v("Action")]),r("a",{staticClass:"dropdown-item",attrs:{href:"#"}},[t._v("Another action")]),r("div",{staticClass:"dropdown-divider"}),r("a",{staticClass:"dropdown-item",attrs:{href:"#"}},[t._v("Something else here")])])])}],O=function(t){Object(c["a"])(r,t);var e=Object(i["a"])(r);function r(){return Object(s["a"])(this,r),e.apply(this,arguments)}return r}(u["b"]);O=l["a"]([u["a"]],O);var j=O,m=j,g=r("2877"),_=Object(g["a"])(m,d,h,!1,null,"26ec2760",null),y=_.exports,w=function(t){Object(c["a"])(r,t);var e=Object(i["a"])(r);function r(){return Object(s["a"])(this,r),e.apply(this,arguments)}return r}(u["b"]);w=l["a"]([Object(u["a"])({components:{ServerSelector:y}})],w);var C=w,S=C,x=Object(g["a"])(S,b,f,!1,null,"42793e2c",null),k=x.exports,$=function(t){Object(c["a"])(r,t);var e=Object(i["a"])(r);function r(){return Object(s["a"])(this,r),e.apply(this,arguments)}return r}(u["b"]);$=l["a"]([Object(u["a"])({components:{SiteNavigation:k}})],$);var E=$,P=E,T=Object(g["a"])(P,p,v,!1,null,"cd556a70",null),M=T.exports,A=function(t){Object(c["a"])(r,t);var e=Object(i["a"])(r);function r(){return Object(s["a"])(this,r),e.apply(this,arguments)}return r}(u["b"]);A=l["a"]([Object(u["a"])({components:{Layout:M}})],A);var J=A,L=J,N=Object(g["a"])(L,n,o,!1,null,null,null),q=N.exports,z=r("8c4f"),B=function(){var t=this,e=t.$createElement,r=t._self._c||e;return r("span",[t._v(t._s(t.message))])},D=[],F=function(t){Object(c["a"])(r,t);var e=Object(i["a"])(r);function r(){var t;return Object(s["a"])(this,r),t=e.apply(this,arguments),t.message="hello, everybody!",t}return r}(u["b"]);F=l["a"]([u["a"]],F);var G=F,H=G,I=Object(g["a"])(H,B,D,!1,null,"c3911e80",null),K=I.exports,Q=function(){var t=this,e=t.$createElement,r=t._self._c||e;return r("p",[t._v("Servers!")])},R=[],U=function(t){Object(c["a"])(r,t);var e=Object(i["a"])(r);function r(){return Object(s["a"])(this,r),e.apply(this,arguments)}return r}(u["b"]);U=l["a"]([u["a"]],U);var V=U,W=V,X=Object(g["a"])(W,Q,R,!1,null,"754dbea1",null),Y=X.exports;a["default"].use(z["a"]);var Z=new z["a"]({routes:[{path:"/",name:"home",component:K},{path:"/servers",name:"server-list",component:Y}]});r("4989"),r("ab8b");a["default"].config.productionTip=!0,new a["default"]({router:Z,render:function(t){return t(q)}}).$mount("#app")}});
//# sourceMappingURL=app.24fbf389.js.map