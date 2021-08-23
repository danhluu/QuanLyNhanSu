<template>
   <v-app id="inspire" class="isHide">
      <v-main>
         <v-container fluid fill-height>
            <v-layout align-center justify-center>
               <v-flex xs12 sm8 md4>
                  <v-card class="elevation-12">
                     <v-toolbar dark color="primary">
                        <v-toolbar-title>Đăng Nhập</v-toolbar-title>
                     </v-toolbar>
                     <v-card-text>
                        <v-form>
                           <v-text-field
                              prepend-icon="mdi-account"
                              name="login"
                              label="Tài khoản"
                              type="text"
                              v-model="Login.username"
                           ></v-text-field>
                           <v-text-field
                              id="password"
                              prepend-icon="mdi-lock"
                              name="password"
                              label="Mật Khẩu"
                              type="password"
                              v-model="Login.password"
                           ></v-text-field>
                        </v-form>
                     </v-card-text>
                     <v-card-actions>
                        <v-spacer></v-spacer>
                        <v-btn  @click="login">Đang Nhập</v-btn>
                     </v-card-actions>
                  </v-card>
               </v-flex>
            </v-layout>
         </v-container>
      </v-main>
   </v-app>
</template>

<script>
// import Vue from 'vue';
import * as axios from "axios";
// import router from 'vue-router'
// Vue.use(router)
export default {
   
    data(){
        return{
            username: "",
            password: "",
            getUsername: "",
            Login:{}
        }
    },
   name: 'Login',
   props: {
      source: String,
   },
   methods:{
       async login() {
          var x = this.$router;
          var y = this.Login;
          await axios.post("https://localhost:5001/api/Login", 
            this.Login
          ).then(function (response) {
               console.log(response);
               if(response.status === 200 && response.data.Session=="QuanLy"){
                  // router.push('QuanLy')
                  x.push({name:"DanhSachNhanVien",params:{data: y}})
                  // console.log(y);
               }
               else if(response.status === 200 && response.data.Session=="NhanVien"){
                  x.push({name:"ThongTinNhanVien",params:{data: y}})
                  // console.log(y);
               }
               else{
                  alert("Sai Tài Khoản Hoặc Mật Khẩu")
                  this.login=false;
               }
               
          }).catch(function(){
             
          })

        }
   }
};
</script>

<style></style>
