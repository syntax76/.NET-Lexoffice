(window.webpackJsonp=window.webpackJsonp||[]).push([[2],{101:function(e,t,a){"use strict";a.r(t);var n=a(0),l=a.n(n),r=a(107),c=a(102),i=a(104),m=a(105);var s=function(e){const{metadata:t}=e;return l.a.createElement("nav",{className:"pagination-nav"},l.a.createElement("div",{className:"pagination-nav__item"},t.previous&&l.a.createElement(m.a,{className:"pagination-nav__link",to:t.previous.permalink},l.a.createElement("h5",{className:"pagination-nav__link--sublabel"},"Previous"),l.a.createElement("h4",{className:"pagination-nav__link--label"},"\xab ",t.previous.title))),l.a.createElement("div",{className:"pagination-nav__item pagination-nav__item--next"},t.next&&l.a.createElement(m.a,{className:"pagination-nav__link",to:t.next.permalink},l.a.createElement("h5",{className:"pagination-nav__link--sublabel"},"Next"),l.a.createElement("h4",{className:"pagination-nav__link--label"},t.next.title," \xbb"))))};var o=function(e,t,a){const[l,r]=Object(n.useState)(void 0);Object(n.useEffect)(()=>{let n=[],c=[];function i(){const i=function(){let e=0,t=null;for(n=document.getElementsByClassName("anchor");e<n.length&&!t;){const l=n[e],{top:r}=l.getBoundingClientRect();r>=0&&r<=a&&(t=l),e+=1}return t}();if(i){let a=0,n=!1;for(c=document.getElementsByClassName(e);a<c.length&&!n;){const e=c[a],{href:m}=e,s=decodeURIComponent(m.substring(m.indexOf("#")+1));i.id===s&&(l&&l.classList.remove(t),e.classList.add(t),r(e),n=!0),a+=1}}}return document.addEventListener("scroll",i),document.addEventListener("resize",i),i(),()=>{document.removeEventListener("scroll",i),document.removeEventListener("resize",i)}})},d=a(103),E=a.n(d),g=a(89),u=a.n(g);function v({headings:e}){return o("contents__link","contents__link--active",100),l.a.createElement("div",{className:"col col--3"},l.a.createElement("div",{className:u.a.tableOfContents},l.a.createElement(p,{headings:e})))}function p({headings:e,isChild:t}){return e.length?l.a.createElement("ul",{className:t?"":"contents contents__left-border"},e.map(e=>l.a.createElement("li",{key:e.id},l.a.createElement("a",{href:`#${e.id}`,className:"contents__link",dangerouslySetInnerHTML:{__html:e.value}}),l.a.createElement(p,{isChild:!0,headings:e.children})))):null}t.default=function(e){const{siteConfig:t={}}=Object(c.a)(),{url:a,title:n}=t,{content:m}=e,{metadata:o}=m,{description:d,title:g,permalink:p,editUrl:h,lastUpdatedAt:_,lastUpdatedBy:N,version:f}=o,{frontMatter:{image:b,keywords:k,hide_title:w,hide_table_of_contents:y}}=m,C=a+Object(i.a)(b);return l.a.createElement(l.a.Fragment,null,l.a.createElement(r.a,null,g&&l.a.createElement("title",null,g," | ",n),d&&l.a.createElement("meta",{name:"description",content:d}),d&&l.a.createElement("meta",{property:"og:description",content:d}),k&&k.length&&l.a.createElement("meta",{name:"keywords",content:k.join(",")}),b&&l.a.createElement("meta",{property:"og:image",content:C}),b&&l.a.createElement("meta",{property:"twitter:image",content:C}),b&&l.a.createElement("meta",{name:"twitter:image:alt",content:`Image for ${g}`}),p&&l.a.createElement("meta",{property:"og:url",content:a+p})),l.a.createElement("div",{className:"padding-vert--lg"},l.a.createElement("div",{className:"container"},l.a.createElement("div",{className:"row"},l.a.createElement("div",{className:E()("col",u.a.docItemCol)},l.a.createElement("div",{className:u.a.docItemContainer},l.a.createElement("article",null,f&&l.a.createElement("span",{style:{verticalAlign:"top"},className:"badge badge--info"},"Version: ",f),!w&&l.a.createElement("header",null,l.a.createElement("h1",{className:u.a.docTitle},g)),l.a.createElement("div",{className:"markdown"},l.a.createElement(m,null))),(h||_||N)&&l.a.createElement("div",{className:"margin-vert--xl"},l.a.createElement("div",{className:"row"},l.a.createElement("div",{className:"col"},h&&l.a.createElement("a",{href:h,target:"_blank",rel:"noreferrer noopener"},l.a.createElement("svg",{fill:"currentColor",height:"1.2em",width:"1.2em",preserveAspectRatio:"xMidYMid meet",viewBox:"0 0 40 40",style:{marginRight:"0.3em",verticalAlign:"sub"}},l.a.createElement("g",null,l.a.createElement("path",{d:"m34.5 11.7l-3 3.1-6.3-6.3 3.1-3q0.5-0.5 1.2-0.5t1.1 0.5l3.9 3.9q0.5 0.4 0.5 1.1t-0.5 1.2z m-29.5 17.1l18.4-18.5 6.3 6.3-18.4 18.4h-6.3v-6.2z"}))),"Edit this page")),(_||N)&&l.a.createElement("div",{className:"col text--right"},l.a.createElement("em",null,l.a.createElement("small",null,"Last updated"," ",_&&l.a.createElement(l.a.Fragment,null,"on"," ",l.a.createElement("time",{dateTime:new Date(1e3*_).toISOString(),className:u.a.docLastUpdatedAt},new Date(1e3*_).toLocaleDateString()),N&&" "),N&&l.a.createElement(l.a.Fragment,null,"by ",l.a.createElement("strong",null,N)),!1))))),l.a.createElement("div",{className:"margin-vert--lg"},l.a.createElement(s,{metadata:o})))),!y&&m.rightToc&&l.a.createElement(v,{headings:m.rightToc})))))}}}]);