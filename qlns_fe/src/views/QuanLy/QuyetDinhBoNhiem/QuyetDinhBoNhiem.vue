<style scoped>
</style>

<template>
  <v-container>
    <NavBarQL />
    <v-card-title class="mb-5">
      QUYẾT ĐỊNH BỔ NHIỆM
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
      Bổ Nhiệm nhân viên
    </v-btn>
    <ThemQuyetDinhBoNhiem :QuyetDinhBoNhiem="QuyetDinhBoNhiem" :dialogUpdate="dialog" @closePopup="closePopup" @loadDL="loadDL"/>
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
            <td style="width:5%;" class="KhongCoGi"></td>
          <td style="width:25%;">{{item.NgayBoNhiem}}</td>
          <td style="width:20%;">{{item.TenNhanVien}}</td>
          <td style="width:20%;">{{item.TenQuanLy}}</td>
          <td style="width:20%;">{{item.TenChucVu}}</td>
          
        </tr>
      </template>
    </v-data-table>
    
  </v-container>
</template>
<script>
import axios from 'axios'
import NavBarQL from "../../../components/Layout/NavBarQL"
import ThemQuyetDinhBoNhiem from "../../QuanLy/QuyetDinhBoNhiem/ThemQuyetDinhBoNhiem"
  export default {
    components:{
      NavBarQL,
      ThemQuyetDinhBoNhiem 
    },
    data () {
      return {
        btnColor: "red darkin-2 center",
        status: 0,
        MaQDBN:"",
        dialog: false,
        selectedRows: [],
        tableHeight:0,
        search: '',
        headers: [
            { text: '', value: '', class:'KhongCoGi' },
          { text: 'Ngày Bổ Nhiếm', value: 'NgayBoNhiem', class:'text-lg-h6 font-weight-bold' },
          {
            text: 'Nhân Viên',
            align: 'start',
            // sortable: false,
            value: 'TenNhanVien',
            class:'text-lg-h6 font-weight-bold'
          },
          { text: 'Người bổ nhiệm', value: 'TenQuanLy',class:'text-lg-h6 font-weight-bold' },
          { text: 'Chức Vụ', value: 'TenChucVu',class:'text-lg-h6 font-weight-bold' },
           ],
        datas: [
        ],
        QuyetDinhBoNhiem:{},
      }

    },
    async created(){
      const response = await axios.get("https://localhost:5001/api/QuyetDinhBoNhiems/QuyetDinhBoNhiemHienThi");
      
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
      btnAddOnClick(){
        this.QuyetDinhBoNhiem={
            NgayBoNhiem: "",
            IsHide: 1,
            MaNV: null,
            MaQL: null,
            MaChucVu: null,
        }
        console.log(this.QuyetDinhBoNhiem)
        this.dialog = true;
      },
      async loadDL(){
        const response = await axios.get("https://localhost:5001/api/QuyetDinhBoNhiems/QuyetDinhBoNhiemHienThi");
        this.datas = response.data;
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
.KhongCoGi{
    border: none;
}
</style>