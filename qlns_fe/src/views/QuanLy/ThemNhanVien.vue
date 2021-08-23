<template>
  <v-dialog
      v-model="dialogUpdate"
      width="1000"
      persistent
    >
      <v-card>
        <v-card-title class="headline grey lighten-2">
          THÔNG TIN NHÂN VIÊN
          <!-- <v-btn @click="loadDL" class="ml-5">Nhận dữ liệu</v-btn> -->
          <v-btn class="btn_grey btn-close" 
                @click="btnCancelOnClick" 
                depressed
                height="50">
                <v-icon large class="black--text">mdi-close-thick</v-icon>
            </v-btn>
        </v-card-title>
        
        <v-card-text>
            
            <v-form class="mt-3" ref="formValidate">
              
                <v-layout row wrap justify-space-around>
                    <v-flex md5 class="">
                        <v-text-field v-model="NhanVien.username" label="Tên Tài Khoản" required :rules="usernameRules">
                        </v-text-field>
                    </v-flex >
                    <v-flex md5>
                        <v-text-field v-model="NhanVien.password" required :rules="passwordRules" label="Mật Khẩu"  >
                        </v-text-field>
                    </v-flex>
                    <v-flex md5 >
                      <v-select
                      v-model="MaHS"
                      :items="HoSoNhanViens"
                      item-text="MaHSNV"
                      item-value="MaHSNV"
                      label="Mã Hồ Sơ Nhân Viên"
                      persistent-hint
                      return-object
                      single-line
                      :rules="EmptyRules"
                      hint="Mã Nhân Viên Của các nhân viên chưa có tài khoản, có thể bỏ trống"
                      ></v-select>
                    </v-flex>

                    <v-flex md5 >
                      <v-select
                      v-model="MaPB"
                      :items="PhongBan"
                      item-text="TenPhongBan"
                      item-value="MaPhongBan"
                      label="Phòng Ban"
                      persistent-hint
                      return-object
                      single-line
                      :rules="EmptyRules"
                      hint="Mã Nhân Viên Của các nhân viên chưa có tài khoản"
                      ></v-select>
                    </v-flex>
                    
                    <v-flex
                        md5
                    >
                        <v-text-field
                        name="input-7-1"
                        label="Ghi Chú"
                        value=""
                        hint="Một số chú thích về tài khoản nhân viên"
                        v-model="NhanVien.GhiChu"
                        ></v-text-field>
                    </v-flex>
                </v-layout>
            </v-form>
            
          
        </v-card-text>

        <v-divider class="mt-4"></v-divider>

        <v-card-actions class="">
            
          <v-spacer></v-spacer>
          <v-btn @click="btnCancelOnClick" height="50" width="100" depressed class="mr-3">Huỷ</v-btn>
          <v-btn
            @click="saveProduct"
            height="50"
            class="success white--text"
            width="100"
            :loading="loading"
          >
            Thêm
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>
</template>

<script>
import axios from 'axios'
export default {
    props:['dialogUpdate','NhanVien'],
    data(){
        return{
          loading: false,
          items: [ 

          ],
          HoSoNhanViens:[

          ],
          PhongBan: [],
          MaHS: "",
          MaPB: "",
        //   NhanVien:{},
          dialog: this.dialogUpdate,
          CategoryId:"",
          code: '',
          getImage:{},
          usernameRules: [
            v => !!v || 'Tên Tài Khoản ít nhất 2 ký tự',
            v => (v && v.length >= 2) || 'Tên ít nhất 2 ký tự',
          ],
          passwordRules:[
              v => !!v || 'Mật Khẩu ít nhất 6 ký tự'
          ],
          EmptyRules:[
              v=>!!v||'Không được bỏ trống'
          ],
          // product: {
          //   CreatedDate: new Date(),
          //   Description: "",
          //   DisplayOrder: "",
          //   Image: "",
          //   ModifiedDate: new Date(),
          //   Name: "",
          //   Price: "",
          //   Quantity: "",
          //   Weight:""
          // }
        }
    },
    mounted(){
      this.created();
      // if(this.selectedProduct.id != undefined){
      //   this.product = this.selectedProduct;
      //   console.log(this.product)
      // }
    },
    methods:{
      // loadDL(){
      //   // this.product=this.selectedProduct
      // },
      btnCancelOnClick(){
        this.$emit('closePopup',false);
      },
      async saveProduct(){
          
          if(this.MaHS.MaHSNV!=undefined)
            this.NhanVien.MaHSNV = this.MaHS.MaHSNV;
          if(this.MaPB.MaPhongBan!=undefined)
            this.NhanVien.MaPhongBan = this.MaPB.MaPhongBan;
        // Object.assign(this.product, this. selectedProduct)
        if(this.$refs.formValidate.validate()){
            this.loading=true;
            await axios.post("https://localhost:5001/api/NhanViens",this.NhanVien);
            this.NhanVien = {};
            this.$emit("loadDL");
            this.$emit('closePopup',false);
            
        }
        this.loading=false;
      },
      async created(){
         const response = await axios.get("https://localhost:5001/api/HoSoNhanViens/GetMaHSNV");
            const response2 = await axios.get("https://localhost:5001/api/PhongBans");
        this.HoSoNhanViens = response.data;
        this.PhongBan = response2.data;
      },
    }
}
</script>
<style scoped>
.btn-close{
    position: absolute;
    top: 0;
    right: 0;
}
</style>