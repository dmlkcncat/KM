import{r as a,b as l,j as e,d as o,i as s}from"./index-6a111058.js";import{C as c}from"./Card-a3eeeef0.js";import{g as x}from"./request-947fb778.js";const m=()=>x("AboutUs/getall"),h=()=>{const[i,r]=a.useState(!0),[n,d]=a.useState([]);return a.useEffect(()=>{m().then(t=>{d(t.data),r(!1)})},[]),l("div",{children:[e("section",{className:"bg-center bg-no-repeat bg-[url('/img/aboutus.jpg')] bg-gray-400 bg-blend-multiply",style:{height:"350px",width:"100%"},children:e("div",{className:"px-4 mx-auto max-w-screen-xl text-center py-24",children:e("h1",{className:"text-4xl font-extrabold tracking-tight leading-none text-white md:text-5xl lg:text-6xl slider-font items-center",children:"Hakkımızda"})})}),e("div",{className:"flex flex-row gap-4 p-10",children:i?e(o,{}):e(s.Group,{"aria-label":"Pills",style:"pills",className:"mx-auto",children:n.map(t=>l(s.Item,{title:t.title,className:"mx-auto",children:[l("div",{className:"w-full p-4 bg-[#40798c] text-xl font-bold slider-font text-center text-white",children:[t.title,e("div",{className:"aboutus-divider"})]}),e(c,{className:"bg-[#f7f7f7] w-full",children:e("div",{className:"text-[#364e63] mt-8 slider-font p-10 max-w-full w-full",dangerouslySetInnerHTML:{__html:t.text}})})]},t.id))})})]})};export{h as default};