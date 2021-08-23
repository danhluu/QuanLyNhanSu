<style scoped>
.txtThongTin{
    font-size: 20px;
    margin-left: 100px;
    margin-top: 20px;
    font-weight: bold;
}
.contain{
    margin-top: 50px;
}
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
            <v-list-item-group v-model="selectedItem">
                <v-list-item >
                    <v-list-item-icon>
                        <v-icon class="white--text">mdi-account-circle</v-icon>
                    </v-list-item-icon>
                    <v-list-item-content>
                        <v-list-item-title  class="white--text">Thông tin cá nhân</v-list-item-title>
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

                <v-list-item >
                    <v-list-item-icon>
                        <v-icon class="white--text">mdi-lock</v-icon>
                    </v-list-item-icon>
                    <v-list-item-content>
                        <v-list-item-title @click="DoiMatKhau()" class="white--text">Đổi Mật Khẩu</v-list-item-title>
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
    <div class="contain">
        <div class="txtThongTin red--text">Họ Tên: <span class="black--text">{{ThongTin.HoTen}}</span></div>
        <div class="txtThongTin red--text">username: <span class="black--text">{{ThongTin.username}}</span></div>
        <div class="txtThongTin red--text">Email: <span class="black--text">{{ThongTin.Email}}</span></div>
        <div class="txtThongTin red--text">Tên Phòng Ban: <span class="black--text">{{ThongTin.TenPhongBan}}</span></div>
        <div class="txtThongTin red--text">Địa Chỉ: <span class="black--text">{{ThongTin.DiaChi}}</span></div>
        <div class="txtThongTin red--text">Quê Quán: <span class="black--text">{{ThongTin.QueQuan}}</span></div>
        <div class="txtThongTin red--text">Ngày Sinh: <span class="black--text">{{ThongTin.NgaySinh}}</span></div>
        <div class="txtThongTin red--text">Trường Học: <span class="black--text">{{ThongTin.TruongHoc}}</span></div>
        <div class="txtThongTin red--text">Số điện thoại: <span class="black--text">{{ThongTin.sdt}}</span></div>
    </div>
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
          selectedItem: 0,
          drawer: true,
          user:{
              username:"ndl",
              pasword:"456"
          },
          ThongTin:{},
      }
    },
    async created(){
        if(this.$route.params.data!=null)
            this.user = this.$route.params.data
        
        if(this.user.username!=""){
            const res = await axios.get("https://localhost:5001/api/HoSoNhanViens/HienThi/"+this.user.username);
            this.ThongTin = res.data
            console.log(this.ThongTin)
        }
        else{
            console.log("zz");
        }
        
    },
    methods:{
        DangXuat(){
          this.$router.push("/");
        },
        GuiDon(){
            var x = this.$router;
            var y = this.user
            x.push({name: "DonXinNhanVien",params: {data: y}})
        },
        DoiMatKhau(){
            var x = this.$router;
            var y = this.user
            x.push({name: "DoiMatKhau",params: {data: y}})
        }
    }
  }
</script>