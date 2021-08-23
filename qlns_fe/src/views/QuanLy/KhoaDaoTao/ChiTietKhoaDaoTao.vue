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

    <v-data-table
      :headers="headers"
      :items="ChiTietKhoaDaoTao"
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
          <td style="width:7%;">{{item.MaHV}}</td>
          <td style="width:10%;">{{item.TenHocVien}}</td>
          <td style="width:15%;">{{item.Truong}}</td>
        </tr>
      </template>
    </v-data-table>
  </v-container>
</template>

<script>
import Vue from 'vue'
import router from '../../../router'
import axios from 'axios'
import NavBarQL from "../../../components/Layout/NavBarQL"
Vue.use(router)
export default {
    components:{
        NavBarQL
    },
    data(){
        return{
            ChiTietKhoaDaoTao:[],
            search: '',
            headers: [
                { text: 'Mã Học Viên', value: 'MaHV', class:'text-lg-h6 font-weight-bold' },
                {
                    text: 'Tên Học Viên',
                    align: 'start',
                    value: 'TenHocVien',
                    class:'text-lg-h6 font-weight-bold'
                },
                { text: 'Trường', value: 'Truong',class:'text-lg-h6 font-weight-bold' },
            ],
        }
    },
    async created(){
        var path = window.location.pathname;
        var segments = path.split("/");
        var val = segments[4];
        const kdt = await axios.get("https://localhost:5001/api/ChiTietKhoaDaoTaos/Lop/"+val);
        this.ChiTietKhoaDaoTao = kdt.data;
        console.log(this.ChiTietKhoaDaoTao)
    }
}
</script>
<style scoped>
td{
  border-left: 1px solid #e0e0e0;
  border-bottom: 1px solid #e0e0e0;
  font-size:18px !important;
  cursor: pointer;
}
.v-data-footer__select{
  font-size: 30px !important;
}
</style>