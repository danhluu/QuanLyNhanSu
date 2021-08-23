<style scoped>
</style>

<template>
  <v-container>
    <NavBarQL />
    <v-card-title class="mb-5">
      DANH SÁCH NHÂN VIÊN
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
      Thêm mới nhân viên
    </v-btn>
    <ThemHoSoNhanVien :HoSoNhanVien="HoSoNhanVien" :dialogUpdate="dialog" @closePopup="closePopup" @loadDL="loadDL"/>
     <!-- <v-btn @click="LoadData" class="float-right mr-5 success" height="40">Load Dữ Liệu</v-btn>  -->
    <v-data-table
      :headers="headers"
      :items="nhanviens"
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
          <td style="width:10%;">{{item.MaHSNV}}</td>
          <td style="width:15%;">{{item.HoTen}}</td>
          <td style="width:10%;">{{item.DiaChi}}</td>
          <td style="width:10%;">{{item.QueQuan}}</td>
          <td style="width:10%;">{{item.NgaySinh}}</td>
          <td style="width:10%;">{{item.Email}}</td>
          <td style="width:12%;">{{item.sdt}}</td>
          <td style="width:8%;">{{item.TruongHoc}}</td>
          
          
          <td style="width:15%;">
            <v-btn @click="rowClicked(item)" class="red dark white--text ml-2">Sửa</v-btn>
            <v-btn @click="DeleteData(item.MaHSNV)" class="primary dark white--text ml-2">Xoá</v-btn>
          </td>
        </tr>
      </template>
    </v-data-table>
    <XoaHoSo :dialogDelete="dialogDelete" @closeDeletePopup="closeDeletePopup" :MaHSNV="MaHSNV" @loadDL="loadDL"/>
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
import ThemHoSoNhanVien from "../../QuanLy/HoSoNhanVien/ThemHoSoNhanVien"
import XoaHoSo from "../../QuanLy/HoSoNhanVien/XoaHoSo"
  export default {
    components:{
      NavBarQL,
      ThemHoSoNhanVien,
      XoaHoSo
    },
    data () {
      return {
        btnColor: "red darkin-2 center",
        status: 0,
        MaHSNV:"",
        dialog: false,
        dialogDelete: false,
        selectedRows: [],
        tableHeight:0,
        search: '',
        headers: [
          { text: 'Mã Hồ Sơ', value: 'MaHSNV', class:'text-lg-h6 font-weight-bold' },
          {
            text: 'Tên Nhân Viên',
            align: 'start',
            // sortable: false,
            value: 'HoTen',
            class:'text-lg-h6 font-weight-bold'
          },
          { text: 'Địa Chỉ', value: 'DiaChi',class:'text-lg-h6 font-weight-bold' },
          { text: 'Quê Quán', value: 'QueQuan' ,class:'text-lg-h6 font-weight-bold'},
          { text: 'Ngày Sinh', value: 'NgaySinh' ,class:'text-lg-h6 font-weight-bold'},
          { text: 'Email', value: 'Email' ,class:'text-lg-h6 font-weight-bold'},
          { text: 'Số điện thoại', value: 'sdt' ,class:'text-lg-h6 font-weight-bold'},
          { text: 'Trường Học', value: 'TruongHoc' ,class:'text-lg-h6 font-weight-bold'},
          { text: 'Chức Năng', value: 'ChucNang' ,class:'text-lg-h6 font-weight-bold'},
        ],
        product:{},
        nhanviens: [
        ],
        HoSoNhanVien:{},
      }

    },
    async created(){
      const response = await axios.get("https://localhost:5001/api/HoSoNhanViens");
      
      this.nhanviens = response.data;
      this.nhanviens.forEach(element => {
        if(element.NgaySinh!=null)
        element.NgaySinh = this.formatDate(element.NgaySinh)
      });

      console.log(this.nhanviens)
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
      btnAddOnClick(){
        this.HoSoNhanVien={
          HoTen: "",
          DiaChi: "",
          QueQuan: "",
          NgaySinh: "",
          Email: "",
          sdt: "",
          TruongHoc: "",
          IsHide: 1,
        }
        console.log(this.HoSoNhanVien)
        this.dialog = true;
      },
      async loadDL(){
        const response = await axios.get("https://localhost:5001/api/HoSoNhanViens");
        this.nhanviens = response.data;
      },
      rowClicked(row){
        this.dialog = true;
        this.HoSoNhanVien = row;
        this.HoSoNhanVien.NgaySinh = new Date(this.HoSoNhanVien.NgaySinh).toISOString().substr(0, 10);
        console.log(this.HoSoNhanVien);
      },
      DeleteData(id){
        console.log(id);
        this.dialogDelete = true;
        this.MaHSNV = id;
      },
      formatDate(date){
        var d = new Date(date);
        var day = d.getDay();
        var month = d.getMonth()+1;
        if(month<10){
          month = "0"+month;
        }
        if(day<10){
          day = "0"+day;
        }
        var year = d.getFullYear();
        return month+"/"+day+"/"+year;
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