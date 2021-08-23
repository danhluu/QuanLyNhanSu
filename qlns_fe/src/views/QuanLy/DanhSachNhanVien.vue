<style scoped>
</style>

<template>
  <v-container>
    <NavBarQL />
    <v-card-title class="mb-5">
      <div>Quản Lý: {{user.username}}</div>
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
    <ThemNhanVien :NhanVien="NhanVien" :dialogUpdate="dialog" @closePopup="closePopup" @loadDL="loadDL"/>
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
          <td style="width:12%;">{{item.MaNV}}</td>
          <td style="width:20%;">{{item.TenNV}}</td>
          <td style="width:20%;">{{item.PhongBan}}</td>
          <td style="width:15%;">{{item.username}}</td>
          <td v-if="setStatus(item.Status)" @click="changeStatus(item)" style="width:13%;"><v-btn :class="btnColor" class="white--text" width="100">Mở</v-btn></td>
          <td v-else style="width:13%;"><v-btn @click="changeStatus(item)" width="100">Khoá</v-btn></td>
          
          <td style="width:20%;">
            <v-btn @click="DeleteData(item.MaNV)" class="primary dark white--text ml-2">Xoá</v-btn>
          </td>
        </tr>
      </template>
    </v-data-table>
    <XoaNhanVien :dialogDelete="dialogDelete" @closeDeletePopup="closeDeletePopup" :MaNV="MaNV" @loadDL="loadDL"/>
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
import NavBarQL from "../../components/Layout/NavBarQL"
import ThemNhanVien from "../QuanLy/ThemNhanVien"
import XoaNhanVien from "../QuanLy/XoaNhanVien"
  export default {
    components:{
      NavBarQL,
      ThemNhanVien,
      XoaNhanVien
    },
    data () {
      return {
        user:{},
        MaNV: "",
        btnColor: "red darkin-2 center",
        status: 0,
        productId:"",
        dialog: false,
        dialogDelete: false,
        selectedRows: [],
        tableHeight:0,
        search: '',
        headers: [
          { text: 'Nhân Viên', value: 'MaNV', class:'text-lg-h6 font-weight-bold' },
          {
            text: 'Tên Nhân Viên',
            align: 'start',
            // sortable: false,
            value: 'TenNV',
            class:'text-lg-h6 font-weight-bold'
          },
          { text: 'Phòng Ban', value: 'PhongBan',class:'text-lg-h6 font-weight-bold' },
          { text: 'Tên Tài Khoản', value: 'username' ,class:'text-lg-h6 font-weight-bold'},
          { text: 'Trạng Thái', value: 'Status' ,class:'text-lg-h6 font-weight-bold'},
          { text: 'Chức Năng', value: 'iron' ,class:'text-lg-h6 font-weight-bold'},
        ],
        product:{},
        nhanviens: [
        ],
        NhanVien:{},
      }

    },
    async created(){
      const response = await axios.get("https://localhost:5001/api/HienThiNhanVien");
      
      this.nhanviens = response.data;
      
      if(this.user.username==undefined){
        console.log("123")
        // this.$router.push("/")
      }
      else{
        this.user = this.$route.params.data
        console.log(this.user)
      }
      
     
      // console.log(this.nhanviens)
    },

    // mounted(){
    //   this.created();
    // },
    methods:{
      changeStatus(item){
        if(item.Status==0){
          item.Status=1;
        }else{
          item.Status=0;
        }
        axios.post("https://localhost:5001/api/NhanViens/"+item.MaNV,item.MaNV);

      },
      setStatus(stt){
        if(stt==0){
          return false;
        }
        else return true;

      },
      closePopup() {
        this.dialog = false;
      },
      closeDeletePopup(){
        this.dialogDelete = false;
      },
      btnAddOnClick(){
        this.product={
          CreatedDate: new Date(),
          Description: "",
          DisplayOrder: "",
          Image: "",
          ModifiedDate: new Date(),
          Name: "",
          Price: "",
          Quantity: "",
          Weight:""
        }
        this.dialog = true;
      },
      async loadDL(){
        const response = await axios.get("https://localhost:5001/api/HienThiNhanVien");
        
        this.nhanviens = response.data;
      },
      // LoadData(){
      //   this.created();
      // },
      DeleteData(id){
        console.log(id);
        this.dialogDelete = true;
        this.MaNV = id;
        // db.collection('Product').doc(id).delete();
        // console.log("Deleted");
        // this.created()
      },
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