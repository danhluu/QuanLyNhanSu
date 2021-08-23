<style scoped>
</style>

<template>
  <v-container>
    <NavBarQL />
    <v-card-title class="mb-5">
      ĐƠN
      <v-spacer></v-spacer>
      <v-text-field
        v-model="search"
        append-icon="mdi-magnify"
        label="Search"
        single-line
        hide-details
      ></v-text-field>
    </v-card-title>
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
          <td style="width:8%;">{{item.MaDon}}</td>
          <td style="width:10%;">{{item.LoaiDon}}</td>
          <td style="width:15%;">{{item.NgayViet}}</td>
          <td style="width:10%;">{{item.LyDo}}</td>
          <td style="width:10%;">{{item.MaNV}}</td>
          <td v-if="setStatus(item.Status)" @click="changeStatus(item)" style="width:13%;"><v-btn :class="btnColor" class="white--text" width="100">Đã Duyệt</v-btn></td>
          <td v-else style="width:13%;"><v-btn @click="changeStatus(item)" width="100">Chưa Duyệt</v-btn></td>
          
          
        </tr>
      </template>
    </v-data-table>
    
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
  export default {
    components:{
      NavBarQL,
    },
    data () {
      return {
        btnColor: "red darkin-2 center",
        status: 0,
        MaThuong:"",
        dialog: false,
        dialogDelete: false,
        selectedRows: [],
        tableHeight:0,
        search: '',
        headers: [
          { text: 'Mã Đơn', value: 'MaDon', class:'text-lg-h6 font-weight-bold' },
          {
            text: 'Loại Đơn',
            align: 'start',
            // sortable: false,
            value: 'LoaiDon',
            class:'text-lg-h6 font-weight-bold'
          },
          { text: 'Ngày Viết', value: 'NgayViet',class:'text-lg-h6 font-weight-bold' },
          { text: 'Nội Dung', value: 'LyDo' ,class:'text-lg-h6 font-weight-bold'},
          { text: 'Mã Nhân Viên', value: 'MaNV' ,class:'text-lg-h6 font-weight-bold'},
          { text: 'Trạng Thái', value: 'Status' ,class:'text-lg-h6 font-weight-bold'},
        ],
        datas: [
        ],
        DonXin:{},
      }

    },
    async created(){
      const response = await axios.get("https://localhost:5001/api/DonXins");
      
      this.datas = response.data;

      console.log(this.datas)
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
        axios.post("https://localhost:5001/api/DonXins/"+item.MaDon,item.MaDon);

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
      async loadDL(){
        const response = await axios.get("https://localhost:5001/api/DonXins");
        this.datas = response.data;
      },
      rowClicked(row){
        this.dialog = true;
        this.Thuong = row;
        console.log(this.Thuong);
      },
      DeleteData(id){
        console.log(id);
        this.dialogDelete = true;
        this.MaThuong = id;
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