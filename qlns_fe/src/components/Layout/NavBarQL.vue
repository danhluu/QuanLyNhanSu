<template>
  <nav>
    <v-app-bar flat app class="tool_bar" height="60">
        <v-app-bar-nav-icon class="" @click="drawer = !drawer"></v-app-bar-nav-icon>
        <v-toolbar-title class="text-uppercase">
            <span class="font-weight-light">quan ly </span>
            <span class="red--text"> NHAN VIEN</span>
        </v-toolbar-title>
        <v-spacer></v-spacer>
        
    </v-app-bar>
    <v-navigation-drawer width="350" dark flat app v-model="drawer" class="dark_navigation white--text">
        <v-list shaped>
            <v-subheader class="white--text font-weight-bold text-h5">QUẢN LÝ NHÂN VIÊN</v-subheader>
            <v-list-group
                v-for="item in items"
                :key="item.title"
                v-model="item.active"
                :prepend-icon="item.action"
                no-action
            >
                <template v-slot:activator>
                <v-list-item-content>
                    <v-list-item-title v-text="item.title"></v-list-item-title>
                </v-list-item-content>
                </template>

                <v-list-item 
                v-for="child in item.items"
                :key="child.title"
                router :to="child.route"
                >
                <v-icon>mdi-circle-medium</v-icon>
                <v-list-item-content>
                    <v-list-item-title  v-text="child.title"></v-list-item-title>
                </v-list-item-content>
                </v-list-item>
            </v-list-group>
            <v-list-item-content>
                    <v-btn href="/"> Đăng Xuất</v-btn>
                </v-list-item-content>
        </v-list>
    </v-navigation-drawer>
  </nav>
</template>
<script>
import axios from 'axios';
import Vue from 'vue';
var Don = new Vue({
    data(){
        return{
            x:0
        }
    },
    async created(){
        const zz = await axios.get("https://localhost:5001/api/DonXins/CountDonXin");
        
        this.x=zz.data
        console.log(this.x)
    },
    template:'<span>{{x}}</span>'

})

  export default {
    data(){
        return{
            items: [
                {
                    action: 'mdi-account',
                    items: [
                        { title: 'Thông Tin Nhân Viên', route: '/QuanLy/NhanVien' },
                        { title: 'Hồ Sơ Nhân Viên', route: '/QuanLy/HoSoNhanVien' },
                        { title: 'Bằng Cấp', route: '/QuanLy/BangCap' },
                        
                    ],
                    title: 'Quản Lý Nhân Viên',
                },
                {
                    action: 'mdi-alpha-c-circle',
                    items: [
                        { title: 'Quản Lý Lương' , route: '/QuanLy/Luong'},
                        { title: 'Quản Lý Thưởng' , route: '/QuanLy/Thuong'},
                        { title: 'Quản Lý Phụ Cấp' , route: '/QuanLy/PhuCap'},
                        { title: 'Quản Lý Bậc Lương' , route: '/QuanLy/BacLuong'}
                    ],
                    title: 'Quản Lý Lương Thưởng',
                    },
                {
                    action: 'mdi-run',
                    items: [
                        { title: 'Danh Sách Đơn ('+Don.$data.x+')', route: '/QuanLy/DonXin' },
                    ],
                    title: 'Quản Lý Đơn',
                    },
                {
                    action: 'mdi-account-box-multiple-outline',
                    items: [
                        { title: 'Hợp Đồng', route: '/QuanLy/HopDong' },
                        { title: 'Hợp đồng nhân viên', route: '/QuanLy/HopDong/ChiTiet' },
                        
                    ],
                    title: 'Quản Lý Hợp Đồng',
                },
                {
                    action: 'mdi-bag-checked',
                    items: [
                        { title: 'Bổ Nhiệm Nhân Viên', route: '/QuanLy/BoNhiem' },
                        { title: 'Chức vụ', route: '/QuanLy/ChucVu' },
                        
                    ],
                    title: 'Bổ Nhiệm',
                },
                {
                    action: 'mdi-tag',
                    items: [
                        { title: 'Danh Sách Khoá Học', route: '/QuanLy/KhoaDaoTao' },
                        
                    ],
                    title: 'Quản Lý Đào Tạo',
                },
                {
                    action: 'mdi-bank',
                    items: [
                        { title: 'Phòng Ban', route: '/QuanLy/PhongBan' },
                        { title: 'Chuyển Phòng Ban', route: '/QuanLy/PhongBanNhanVien' },
                        
                    ],
                    title: 'Phòng Ban',
                },
                
            ],
            drawer: true
        }
    },
    created(){
        this.Don=5;
    }
  }
</script>