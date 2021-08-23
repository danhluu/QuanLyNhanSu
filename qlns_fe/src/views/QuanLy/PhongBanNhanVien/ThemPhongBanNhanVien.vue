<template>
  <v-dialog
      v-model="dialogUpdate"
      width="1000"
      persistent
    >
      <v-card>
        <v-card-title class="headline grey lighten-2">
          THÔNG TIN
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
                    <v-flex md5 >
                      <v-select
                      v-model="MaNV"
                      :items="NhanViens"
                      item-text="username"
                      item-value="MaNV"
                      label="Nhân Viên"
                      persistent-hint
                      return-object
                      single-line
                      :rules="EmptyRules"
                      ></v-select>
                    </v-flex>

                    <v-flex md5 >
                      <v-select
                      v-model="MaPB"
                      :items="PhongBans"
                      item-text="TenPhongBan"
                      item-value="MaPhongBan"
                      label="Phòng Ban"
                      persistent-hint
                      return-object
                      single-line
                      :rules="EmptyRules"
                      ></v-select>
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
    props:['dialogUpdate','PBNV'],
    data(){
        return{
            MaPB:"",
            PhongBans:[],
            MaNV:"",
            NhanViens:[],
            loading: false,
            items: [ 

            ],
            dialog: this.dialogUpdate,
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
            NumberRules:[
                v=> {
                     if (Number.isNaN(parseInt(v))){
                         return "Phải là số";
                     }
                     return true;
                }
            ],
        }
    },
    async created(){
        const pb = await axios.get("https://localhost:5001/api/PhongBans");
        this.PhongBans = pb.data;
    
        const nv = await axios.get("https://localhost:5001/api/NhanViens");
        this.NhanViens = nv.data;
    
    },
    methods:{
        btnCancelOnClick(){
            this.$emit('closePopup',false);
        },
        async saveProduct(){
            if(this.MaNV.MaNV!=undefined)
                this.PBNV.MaNV = this.MaNV.MaNV;
            if(this.MaPB.MaPhongBan!=undefined)
                this.PBNV.MaPB = this.MaPB.MaPhongBan;
            if(this.$refs.formValidate.validate()){
                console.log(this.PBNV)
                if(this.PBNV.MaPBNV==undefined){
                    this.loading=true;
                    await axios.post("https://localhost:5001/api/PhongBanNhanVien/Add",this.PBNV);
                    console.log(this.PBNV)
                    this.PBNV = {};
                    this.$emit('closePopup',false);
                }
                this.$emit("loadDL");
                
                
            }
            this.loading=false;
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
.dateField{
    margin-top: 20px;
    width: 200px;
    height: 30px;
}
.dateField_input{
    height: 30px;
    width: 150px;
    margin-left: 20px;
}
</style>