<style scoped>
</style>

<template>
  <v-container>
    <NavBarQL />
    <v-card-title class="mb-5">
      KHOÁ ĐÀO TẠO
      <v-spacer></v-spacer>
      <v-text-field
        v-model="search"
        append-icon="mdi-magnify"
        label="Search"
        single-line
        hide-details
      ></v-text-field>
    </v-card-title>
    <v-btn 
      dark
      class="mb-3 dark_navigation ml-5"
      height="40"
      @click="btnAddOnClick"
    >
      Thêm Khoá đào tạo
    </v-btn>
    <ThemKhoaDaoTao :KhoaDaoTao="KhoaDaoTao" :dialogUpdate="dialog" @closePopup="closePopup" @loadDL="loadDL"/>
     <!-- <v-btn @click="LoadData" class="float-right mr-5 success" height="40">Load Dữ Liệu</v-btn>  -->
    <v-data-table
      :headers="headers"
      :items="datas"
      :search="search"
      height="350"
      fixed-header
      :footer-props="{
        'items-per-page-options': [3,6, 10, 20, 50, 1000],
        showFirstLastPage: true,
        firstIcon: 'mdi-chevron-double-left',
        lastIcon: 'mdi-chevron-double-right',
        prevIcon: 'mdi-chevron-left',
        nextIcon: 'mdi-chevron-right',
           'items-per-page-text':'Số Bản Ghi / Trang',
      }"
      :items-per-page="6"
      no-results-text="Không có"
    >
      <template  v-slot:item="{ item }">

        <tr class="mb-3 body-1" style="">
          <td style="width:7%;">{{item.MaKhoaDaoTao}}</td>
          <td style="width:10%;">{{item.TenKhoa}}</td>
          <td style="width:15%;">{{item.NgayBatDau}}</td>
          <td style="width:15%;">{{item.NgayKetThuc}}</td>
          <td style="width:12%;">{{item.TenNhanVien}}</td>
          
          
          <td style="width:20%;">
            <v-btn @click="rowClicked(item)" class="red dark white--text ml-2">Sửa</v-btn>
            <v-btn @click="DeleteData(item.MaKhoaDaoTao)" class="primary dark white--text ml-2">Xoá</v-btn>
            <v-btn @click="ChiTiet(item.MaKhoaDaoTao)" class="primary dark white--text ml-2">Chi Tiết</v-btn>
          </td>
        </tr>
      </template>
    </v-data-table>
    <XoaKhoaDaoTao :dialogDelete="dialogDelete" @closeDeletePopup="closeDeletePopup" :MaKhoaDaoTao="MaKhoaDaoTao" @loadDL="loadDL"/>
    <!-- <v-data-table
    :headers="headers"
    :items="nhanviens"
    :items-per-page="5"
    class="elevation-1"
  >
    <td style="width:20%;">
      <v-btn @click="rowClicked(item)"  dark class="primary">Sửa</v-btn>
      <v-btn @click="DeleteData(item.id)" class="ml-2">Xoá</v-btn>
    </td>
  </v-data-table> -->
  </v-container>
</template>
<script>
import axios from 'axios'
import NavBarQL from "../../../components/Layout/NavBarQL"
import ThemKhoaDaoTao from "../../QuanLy/KhoaDaoTao/ThemKhoaDaoTao"
import XoaKhoaDaoTao from "../../QuanLy/KhoaDaoTao/XoaKhoaDaoTao"
import Vue from 'vue'
import router from '../../../router'
Vue.use(router)
  export default {
    components:{
      NavBarQL,
      ThemKhoaDaoTao ,
      XoaKhoaDaoTao,
    },
    data () {
      return {
        btnColor: "red darkin-2 center",
        status: 0,
        MaKhoaDaoTao:"",
        ChiTietKhoa:[],
        dialog: false,
        dialogDelete: false,
        dialogDetail:false,
        selectedRows: [],
        tableHeight:0,
        search: '',
        headers: [
          { text: 'Mã Khoá', value: 'MaKhoaDaoTao', class:'text-lg-h6 font-weight-bold' },
          {
            text: 'Tên Khoá',
            align: 'start',
            // sortable: false,
            value: 'TenKhoa',
            class:'text-lg-h6 font-weight-bold'
          },
          { text: 'Ngày Bắt Đầu', value: 'NgayBatDau',class:'text-lg-h6 font-weight-bold' },
          { text: 'Ngày Kết Thúc', value: 'NgayKetThuc',class:'text-lg-h6 font-weight-bold' },
          { text: 'Giảng Viên', value: 'TenNhanVien',class:'text-lg-h6 font-weight-bold' },
          { text: 'Chức Năng', value: 'ChucNang' ,class:'text-lg-h6 font-weight-bold'},
        ],
        datas: [
        ],
        KhoaDaoTao:{},
      }

    },
    async created(){
      const response = await axios.get("https://localhost:5001/api/KhoaDaoTaos/HienThi");
      
      this.datas = response.data;

      console.log(this.datas)
    },

    // mounted(){
    //   this.created();
    // },
    methods:{
      
      closePopup() {
        this.dialog = false;
      },
      closeDeletePopup(){
        this.dialogDelete = false;
      },
      closeDetailPopup(){
        this.dialogDetail = false;
      },
      btnAddOnClick(){
        this.KhoaDaoTao={
            TenKhoa: "",
            NgayBatDau: "",
            NgayKetThuc: "",
            IsHide: 1,
            MaNV: null,
        }
        console.log(this.KhoaDaoTao)
        this.dialog = true;
      },
      async loadDL(){
        const response = await axios.get("https://localhost:5001/api/KhoaDaoTaos/HienThi");
        this.datas = response.data;
      },
      rowClicked(row){
        this.dialog = true;
        this.KhoaDaoTao = row;
        console.log(this.KhoaDaoTao);
      },
      DeleteData(id){
        console.log(id);
        this.dialogDelete = true;
        this.MaKhoaDaoTao = id;
      },
      ChiTiet(id){
       this.$router.push("/QuanLy/KhoaDaoTao/ChiTiet/"+id)
       this.$route.params.id
      }
    },
    computed:{
      pageTxt(){
        return this.$vuetify.dataFooter.pageText
      },
     
    }
  }
</script>
<style scoped>
td{
  border-left: 1px solid #e0e0e0;
  border-bottom: 1px solid #e0e0e0;
  font-size:20px !important;
  cursor: pointer;
}
.v-data-footer__select{
  font-size: 30px !important;
}
.border-left{
  border-left: 1px solid #e0e0e0 ;
  background-color: black;
}
</style>