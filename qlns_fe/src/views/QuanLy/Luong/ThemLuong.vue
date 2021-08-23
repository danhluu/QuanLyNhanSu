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
                    <v-flex md5 class="">
                        <v-text-field 
                        v-model="Luong.Thang" 
                        label="Tháng" 
                        required :rules="EmptyRules"
                        persistent-hint
                        hint="Tháng/Năm"
                        >
                        </v-text-field>
                    </v-flex >
                    
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
                      v-model="MaPC"
                      :items="PhuCaps"
                      item-text="LoaiPhuCap"
                      item-value="MaPhuCap"
                      label="Phụ Cấp"
                      persistent-hint
                      return-object
                      single-line
                      :rules="EmptyRules"
                      ></v-select>
                    </v-flex>

                    <v-flex md5 >
                      <v-select
                      v-model="MaBL"
                      :items="BacLuongs"
                      item-text="LoaiLuong"
                      item-value="MaBacLuong"
                      label="Bậc Lương"
                      persistent-hint
                      return-object
                      single-line
                      :rules="EmptyRules"
                      ></v-select>
                    </v-flex>

                    <v-flex md5 >
                      <v-select
                      v-model="MaThuong"
                      :items="Thuongs"
                      item-text="LoaiThuong"
                      item-value="MaThuong"
                      label="Thưởng"
                      persistent-hint
                      return-object
                      single-line
                      :rules="EmptyRules"
                      hint="Mã Nhân Viên Của các nhân viên chưa có tài khoản"
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
    props:['dialogUpdate','Luong'],
    data(){
        return{
            MaNV:"",
            NhanViens:[],
            MaPC:"",
            PhuCaps:[],
            MaBL:"",
            BacLuongs:[],
            MaThuong:"",
            Thuongs:[],
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
        const nv = await axios.get("https://localhost:5001/api/NhanViens");
        this.NhanViens = nv.data;

        const pc = await axios.get("https://localhost:5001/api/PhuCaps");
        this.PhuCaps = pc.data;

        const bl = await axios.get("https://localhost:5001/api/BacLuong");
        this.BacLuongs = bl.data;

        const th = await axios.get("https://localhost:5001/api/Thuongs");
        this.Thuongs = th.data;
    },
    methods:{
        btnCancelOnClick(){
            this.$emit('closePopup',false);
        },
        async saveProduct(){
            if(this.MaNV.MaNV!=undefined)
                this.Luong.MaNV = this.MaNV.MaNV;
            if(this.MaPC.MaPhuCap!=undefined)
                this.Luong.MaPhuCap = this.MaPC.MaPhuCap;
            if(this.MaBL.MaBacLuong!=undefined)
                this.Luong.MaBacLuong = this.MaBL.MaBacLuong;
            if(this.MaThuong.MaThuong!=undefined)
                this.Luong.MaThuong = this.MaThuong.MaThuong;
            if(this.$refs.formValidate.validate()){
                console.log(this.Luong)
                if(this.Luong.MaLuong==undefined){
                    this.loading=true;
                    await axios.post("https://localhost:5001/api/Luongs/AddLuong",this.Luong);
                    console.log(this.Luong)
                    this.Luong = {};
                    this.$emit('closePopup',false);
                }
                else{
                    this.loading=true;
                    console.log("update")
                    console.log(this.Luong)
                    await axios.put("https://localhost:5001/api/Luongs/UpdateLuong",this.Luong);
                    this.Luong = {};
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