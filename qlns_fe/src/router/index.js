import Vue from 'vue'
import VueRouter from 'vue-router'

Vue.use(VueRouter)

const routes = [
  // {
  //   path: '/',
  //   name: 'Home',
  //   component: Home
  // },
  {
    path: '/QuanLy2',
    name: 'Home',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/QuanLy/Home.vue')
  },
  {
    path: '/',
    name: 'Login',
    component: () => import(/* webpackChunkName: "about" */ '../components/login.vue')
  },
  {
    path: '/QuanLy',
    name: 'QuanLy',
    component: () => import('../components/Layout/NavBarQL.vue')
  },
  {
    path: '/QuanLy/NhanVien',
    name: 'DanhSachNhanVien',
    component: () => import('../views/QuanLy/DanhSachNhanVien.vue')
  },
  {
    path: '/QuanLy/HoSoNhanVien',
    name: 'HoSoNhanVien',
    component: () => import('../views/QuanLy/HoSoNhanVien/HoSoNhanVien.vue')
  },
  {
    path: '/QuanLy/BangCap',
    name: 'BangCap',
    component: () => import('../views/QuanLy/BangCap/BangCap.vue')
  },
  {
    path: '/QuanLy/Luong',
    name: 'Luong',
    component: () => import('../views/QuanLy/Luong/Luong.vue')
  },
  {
    path: '/QuanLy/Thuong',
    name: 'Thuong',
    component: () => import('../views/QuanLy/Thuong/Thuong.vue')
  },
  {
    path: '/QuanLy/PhuCap',
    name: 'PhuCap',
    component: () => import('../views/QuanLy/PhuCap/PhuCap.vue')
  },
  {
    path: '/QuanLy/BacLuong',
    name: 'BacLuong',
    component: () => import('../views/QuanLy/BacLuong/BacLuong.vue')
  },
  {
    path: '/QuanLy/HopDong',
    name: 'HopDong',
    component: () => import('../views/QuanLy/HopDong/HopDong.vue')
  },
  {
    path: '/QuanLy/ChucVu',
    name: 'ChucVu',
    component: () => import('../views/QuanLy/ChucVu/ChucVu.vue')
  },
  {
    path: '/QuanLy/BoNhiem',
    name: 'BoNhiem',
    component: () => import('../views/QuanLy/QuyetDinhBoNhiem/QuyetDinhBoNhiem.vue')
  },
  {
    path: '/QuanLy/KhoaDaoTao',
    name: 'KhoaDaoTao',
    component: () => import('../views/QuanLy/KhoaDaoTao/KhoaDaoTao.vue')
  },
  {
    path: '/QuanLy/KhoaDaoTao/ChiTiet/:id',
    name: 'KhoaDaoTao',
    component: () => import('../views/QuanLy/KhoaDaoTao/ChiTietKhoaDaoTao.vue')
  },
  {
    path: '/QuanLy/DonXin',
    name: 'DonXin',
    component: () => import('../views/QuanLy/DonXin/DonXin.vue')
  },
  {
    path: '/QuanLy/HopDong/ChiTiet',
    name: 'DonXin',
    component: () => import('../views/QuanLy/HopDongNhanVien/HopDongNhanVien.vue')
  },
  {
    path: '/NhanVien/ThongTin',
    name: 'ThongTinNhanVien',
    component: () => import('../views/NhanVien/ThongTin.vue')
  },
  {
    path: '/NhanVien/DonXin',
    name: 'DonXinNhanVien',
    component: () => import('../views/NhanVien/DonXin.vue')
  },
  {
    path: '/NhanVien/DoiMatKhau',
    name: 'DoiMatKhau',
    component: () => import('../views/NhanVien/DoiMatKhau.vue')
  },
  {
    path: '/QuanLy/PhongBan',
    name: 'PhongBan',
    component: () => import('../views/QuanLy/PhongBan/PhongBan.vue')
  },
  {
    path: '/QuanLy/PhongBanNhanVien',
    name: 'PhongBanNhanVien',
    component: () => import('../views/QuanLy/PhongBanNhanVien/PhongBanNhanVien.vue')
  }

]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
