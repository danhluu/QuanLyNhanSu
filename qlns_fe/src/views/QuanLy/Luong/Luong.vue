<style scoped>
</style>

<template>
  <v-container>
    <NavBarQL />
    <v-card-title class="mb-5">
      LƯƠNG
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
      Thêm lương
    </v-btn>
    <ThemLuong :Luong="Luong" :dialogUpdate="dialog" @closePopup="closePopup" @loadDL="loadDL"/>
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
          <td style="width:10%;">{{item.MaLuong}}</td>
          <td style="width:10%;">{{item.luong}}</td>
          <td style="width:15%;">{{item.Thang}}</td>
          <td style="width:10%;">{{item.username}}</td>
          <td style="width:10%;">{{item.MucLuong}}</td>
          <td style="width:10%;">{{item.MucPhuCap}}</td>
          <td style="width:10%;">{{item.MucThuong}}</td>
          
          
          <td style="width:15%;">
            <v-btn @click="rowClicked(item)" class="red dark white--text ml-2">Sửa</v-btn>
            <v-btn @click="DeleteData(item.MaLuong)" class="primary dark white--text ml-2">Xoá</v-btn>
          </td>
        </tr>
      </template>
    </v-data-table>
    <XoaLuong :dialogDelete="dialogDelete" @closeDeletePopup="closeDeletePopup" :MaLuong="MaLuong" @loadDL="loadDL"/>
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
import ThemLuong from "../../QuanLy/Luong/ThemLuong"
import XoaLuong from "../../QuanLy/Luong/XoaLuong"
  export default {
    components:{
      NavBarQL,
      ThemLuong ,
      XoaLuong
    },
    data () {
      return {
        btnColor: "red darkin-2 center",
        status: 0,
        MaLuong:"",
        dialog: false,
        dialogDelete: false,
        selectedRows: [],
        tableHeight:0,
        search: '',
        headers: [
          { text: 'Mã Lương', value: 'MaLuong', class:'text-lg-h6 font-weight-bold' },
          {
            text: 'Lương',
            align: 'start',
            // sortable: false,
            value: 'luong',
            class:'text-lg-h6 font-weight-bold'
          },
          { text: 'Tháng', value: 'Thang',class:'text-lg-h6 font-weight-bold' },
          { text: 'Nhân Viên', value: 'MaNV',class:'text-lg-h6 font-weight-bold' },
          { text: 'Bậc Lương', value: 'MaBacLuong',class:'text-lg-h6 font-weight-bold' },
          { text: 'Phụ Cấp', value: 'MaPhuCap',class:'text-lg-h6 font-weight-bold' },
          { text: 'Thưởng', value: 'Thuong',class:'text-lg-h6 font-weight-bold' },
          { text: 'Chức Năng', value: 'ChucNang' ,class:'text-lg-h6 font-weight-bold'},
        ],
        datas: [
        ],
        Luong:{},
      }

    },
    async created(){
      const response = await axios.get("https://localhost:5001/api/Luongs/HienThi");
      
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
      btnAddOnClick(){
        this.Luong={
            Thang: null,
            NgayTao: "",
            NgaySua: "",
            IsHide: null,
            MaNV: null,
            MaPhuCap: null,
            MaBacLuong: null,
            MaThuong: null,
        }
        console.log(this.Luong)
        this.dialog = true;
      },
      async loadDL(){
        const response = await axios.get("https://localhost:5001/api/Luongs/HienThi");
        this.datas = response.data;
      },
      rowClicked(row){
        this.dialog = true;
        this.Luong = row;
        console.log(this.Luong);
      },
      DeleteData(id){
        console.log(id);
        this.dialogDelete = true;
        this.MaLuong = id;
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