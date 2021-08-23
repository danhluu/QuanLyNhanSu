<style scoped>
</style>

<template>
    
  <v-container>
      <nav>
    <v-app-bar flat app class="tool_bar" height="60">
        <v-app-bar-nav-icon class="" @click="drawer = !drawer"></v-app-bar-nav-icon>
        <v-toolbar-title class="text-uppercase">
            <span class="font-weight-light">quan ly </span>
            <span class="red--text"> NHAN VIEN</span>
        </v-toolbar-title>
        <v-spacer></v-spacer>
        
    </v-app-bar>
    <v-navigation-drawer dark flat app v-model="drawer" class="dark_navigation white--text">
        <v-list shaped>
            <v-subheader class="white--text font-weight-bold">QUẢN LÝ NHÂN VIÊN</v-subheader>
            <v-list-item-group >
                <v-list-item >
                    <v-list-item-icon>
                        <v-icon class="white--text">mdi-account-circle</v-icon>
                    </v-list-item-icon>
                    <v-list-item-content>
                        <v-list-item-title @click="ThongTinNhanVien()" class="white--text">Thông tin cá nhân</v-list-item-title>
                    </v-list-item-content>
                </v-list-item>

                <v-list-item >
                    <v-list-item-icon>
                        <v-icon class="white--text">mdi-message</v-icon>
                    </v-list-item-icon>
                    <v-list-item-content>
                        <v-list-item-title @click="GuiDon()" class="white--text">Gửi Đơn</v-list-item-title>
                    </v-list-item-content>
                </v-list-item>

                <v-list-item v-model="selectedItem">
                    <v-list-item-icon>
                        <v-icon class="white--text">mdi-lock</v-icon>
                    </v-list-item-icon>
                    <v-list-item-content>
                        <v-list-item-title  class="white--text">Đổi Mật Khẩu</v-list-item-title>
                    </v-list-item-content>
                </v-list-item>

                <v-list-item >
                    <v-list-item-icon>
                        <v-icon class="white--text">mdi-send-lock</v-icon>
                    </v-list-item-icon>
                    <v-list-item-content>
                        <v-list-item-title @click="DangXuat" class="white--text">Đăng Xuất</v-list-item-title>
                    </v-list-item-content>
                </v-list-item>

                
            </v-list-item-group>
        </v-list>
        
    </v-navigation-drawer>
      
      </nav>
    <br>
    <v-container>
      <v-form
        ref="form"
      >
        <v-layout row  justify-space-around>

          <v-flex md7 mt-5>
            <v-text-field 
            v-model="matKhauCu"
              :rules="nameRules"
              label="Mật Khẩu Cũ"
              required
            ></v-text-field>
          </v-flex>

          <v-flex md7 mt-5>
            <v-text-field 
              :rules="nameRules"
              v-model="XacNhanMatKhauMoi"
              label="Mật Khẩu Mới"
              required
            ></v-text-field>
          </v-flex>

          <v-flex md7 mt-3>
            <v-text-field 
              v-model="MatKhau.password"
              :rules="nameRules"
              label="Nhập Lại Mật Khẩu"
              required
            ></v-text-field>
          </v-flex>
          
          <v-flex md7 mt-10>
            <v-btn width="150" class="primary dark white--text"
              @click="XacNhanDoiMatKhau"
            >
              Gửi
            </v-btn>
          </v-flex>
            
          </v-layout>
      </v-form>
      
    </v-container>
  </v-container>
</template>
<script>
import axios from 'axios'
// import NavBar from "../../components/Layout/NavBarNhanVien.vue"
  export default {
    components:{
        // NavBar
    },
    data () {
      return {
          XacNhanMatKhauMoi:"",
          valid: true,
          nameRules: [
            v => !!v || 'Không Được để trống',
          ],
          matKhauCu:"",
          selectedItem: 0,
          drawer: true,
          user:{
              username:"ndl",
              pasword:"456"
          },
          ThongTin:{},
          MatKhau:{}
      }
    },
    async created(){
        this.user = this.$route.params.data
        
        console.log(this.user)
        
    },
    methods:{
        DangXuat(){
          this.$router.push("/");
        },
        ThongTinNhanVien(){
            var x = this.$router;
            var y = this.user
            x.push({name: "ThongTinNhanVien",params: {data: y}})
        },
        GuiDon(){
            var x = this.$router;
            var y = this.user
            x.push({name: "DonXinNhanVien",params: {data: y}})
        },
        async XacNhanDoiMatKhau(){
          if(this.matKhauCu!=this.user.password){
            console.log(this.matKhauCu)
            console.log(this.user.password);
            alert("Sai mật khẩu cũ");
          }
          else{
            if(this.XacNhanMatKhauMoi!=this.MatKhau.password){
              alert("Mật Khẩu Không khớp");
            }
            else{
              this.MatKhau.username = this.user.username
              await axios.post("https://localhost:5001/api/NhanViens/DoiMatKhau",this.MatKhau);
              alert("Đổi Thành Công");
            }
            
          }
          
        }
    }
  }
</script>