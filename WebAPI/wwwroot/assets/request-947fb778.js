import{s as f,q as p}from"./index-6a111058.js";function b(t){var e=typeof t;return t!=null&&(e=="object"||e=="function")}var d=b,y=Array.isArray,O=y,S=function t(e,n,o,u){var a=u||"";(function(r){return r===null})(e)||function(r){return r===void 0}(e)?n.excludeNull||o.append(a,""):function(r){return r instanceof File}(e)||function(r){return r instanceof Blob}(e)?o.append(a,e):O(e)?e.forEach(function(r,i){var s=a;n.useBrackets&&(s+="["+(n.arrayIndexes?i:"")+"]"),t(r,n,o,s)}):d(e)?Object.entries(e).forEach(function(r){var i=r[0],s=i;u&&(s=n.useDotSeparator?u+"."+i:u+"["+i+"]"),t(r[1],n,o,s)}):function(r){return typeof r=="boolean"}(e)?o.append(a,n.booleanAsNumbers?""+Number(e):e?"true":"false"):o.append(a,e)},h={arrayIndexes:!0,excludeNull:!0,useDotSeparator:!1,useBrackets:!0,booleanAsNumbers:!1},v=function(t,e,n){return e===void 0&&(e={}),n===void 0&&(n=new FormData),t&&(e=Object.assign({},h,e),S(t,e,n)),n};function N(t){return v(t)}function l(t,e=!1,n="GET",o="FORM_DATA"){return new Promise((u,a)=>{const r={method:n,headers:{}},{authSlice:{user:i}}=f.getState();i&&(r.headers.Authorization=`Bearer ${i.token}`),e&&n==="POST"&&(o==="JSON"&&(r.headers["Content-Type"]="application/json"),r.body=o==="JSON"?JSON.stringify(e):N(e),console.log("options.body :>> ",r.body)),fetch("/api/"+t,r).then(async s=>{const c=await s.json();s.ok?u(c):((s.status===401||s.status===403)&&f.dispatch(p(!1)),a(c))}).catch(s=>{a(s)})})}const g=(t,e)=>l(t,e,"POST","JSON"),j=t=>l(t);export{j as g,g as p};