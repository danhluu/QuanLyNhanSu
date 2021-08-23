<template>
  <!-- @click:outside="btnCancelOnClick" : chèn vào v-dialog: muốn đóng dialog khi click vùng ngoài dialog -->
  <v-dialog v-model="dialogDelete" width="500" persistent > 
    <v-card>
      <v-card-title class="headline grey lighten-2">
        XOÁ DỮ LIỆU
        <v-btn
          class="btn_grey btn-close"
          @click="btnCancelOnClick"
          depressed
          height="50"
          
        >
          <v-icon large class="black--text">mdi-close-thick</v-icon>
        </v-btn>
      </v-card-title>

      <v-card-text class="headline mt-5 ml-5 " > <v-icon x-large>mdi-alert</v-icon> <span >Bạn có chắc muốn Xoá? </span> </v-card-text>

      <v-divider class="mt-2"></v-divider>

      <v-card-actions class="">
        <v-spacer></v-spacer>
        <v-btn
          @click="btnCancelOnClick"
          height="50"
          width="100"
          depressed
          class="mr-3"
          >Huỷ</v-btn
        >
        <v-btn
          @click="DeleteData"
          height="50"
          class="success white--text"
          width="100"
          :loading="loading"
        >
          Xoá
        </v-btn>
      </v-card-actions>
    </v-card>
  </v-dialog>
</template>

<script>
import axios from 'axios'
export default {
  props: ["dialogDelete","MaPhongBan"],
  data(){
    return{
        loading: false,
        dialog: this.dialogDelete,

    }
  },
  methods: {
    btnCancelOnClick() {
      this.$emit("closeDeletePopup", false);
    },
    async DeleteData(){
      console.log(this.MaPhongBan)
      await axios.post("https://localhost:5001/api/PhongBans/SetIsHide/"+this.MaPhongBan);
      this.$emit("loadDL");
      this.$emit("closeDeletePopup", false);
    }
  },
};
</script>
<style scoped>
.btn-close {
  position: absolute;
  top: 0;
  right: 0;
}
</style>