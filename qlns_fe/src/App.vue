<template>
  <v-app>
    <v-main>
      <router-view/>
    </v-main>
  </v-app>
</template>

<script>

// import Login from './components/login';
export default {
  name: 'App',
  components:{
    // Login
  },
  data: () => ({
    //
  }),
};
</script>
<style scoped>
  @import "./Styles/main.css";
</style>
