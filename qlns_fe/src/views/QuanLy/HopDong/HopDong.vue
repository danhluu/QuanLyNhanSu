<style scoped>
</style>

<template>
  <v-container>
    <NavBarQL />
    <v-card-title class="mb-5">
      HỢP ĐỒNG
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
      Thêm Hợp Đồng
    </v-btn>
    <ThemHopDong :HopDong="HopDong" :dialogUpdate="dialog" @closePopup="closePopup" @loadDL="loadDL"/>
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

        <tr class="mb-3 body-1">
          <td style="width:10%;">{{item.MaHopDong}}</td>
          <td style="width:50%;">{{item.NoiDung}}</td>
          
          
          <td style="width:20%;">
            <v-btn @click="rowClicked(item)" class="red dark white--text ml-2">Sửa</v-btn>
            <v-btn @click="DeleteData(item.MaHopDong)" class="primary dark white--text ml-2">Xoá</v-btn>
          </td>
        </tr>
      </template>
    </v-data-table>
    <XoaHopDong :dialogDelete="dialogDelete" @closeDeletePopup="closeDeletePopup" :MaHopDong="MaHopDong" @loadDL="loadDL"/>
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
import ThemHopDong from "../../QuanLy/HopDong/ThemHopDong"
import XoaHopDong from "../../QuanLy/HopDong/XoaHopDong"
  export default {
    components:{
      NavBarQL,
      ThemHopDong ,
      XoaHopDong
    },
    data () {
      return {
        btnColor: "red darkin-2 center",
        status: 0,
        MaHopDong:"",
        dialog: false,
        dialogDelete: false,
        selectedRows: [],
        tableHeight:0,
        search: '',
        headers: [
          { text: 'Mã Hợp Đồng', value: 'MaHopDong', class:'text-lg-h6 font-weight-bold' },
          {
            text: 'Nội Dung',
            align: 'start',
            // sortable: false,
            value: 'NoiDung',
            class:'text-lg-h6 font-weight-bold'
          },
          { text: 'Chức Năng', value: 'ChucNang' ,class:'text-lg-h6 font-weight-bold'},
        ],
        datas: [
        ],
        HopDong:{},
      }

    },
    async created(){
      const response = await axios.get("https://localhost:5001/api/HopDongs");
      
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
        this.HopDong={
            NoiDung: "",
            GhiChu: null,
            NgayTao: "",
            NgaySua: "",
            IsHide: 1
        }
        console.log(this.HopDong)
        this.dialog = true;
      },
      async loadDL(){
        const response = await axios.get("https://localhost:5001/api/HopDongs");
        this.datas = response.data;
      },
      rowClicked(row){
        this.dialog = true;
        this.HopDong = row;
        console.log(this.HopDong);
      },
      DeleteData(id){
        console.log(id);
        this.dialogDelete = true;
        this.MaHopDong = id;
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