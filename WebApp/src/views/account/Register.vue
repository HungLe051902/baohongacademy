<template>
  <div id="register" class="d-flex align-items-center flex-column">
    <Brand />
    <p class="fs20p">Đăng ký tài khoản mới</p>
    <div class="register-form">
      <form>
        <div class="form-group">
          <label for="exampleInputEmail1">Email address</label>
          <input
            ref="emailInput"
            type="email"
            class="form-control"
            id="register-exampleInputEmail1"
            aria-describedby="emailHelp"
            placeholder="Enter email"
          />
        </div>
        <div class="form-group">
          <label for="exampleInputPassword1">Password</label>
          <input
            type="password"
            class="form-control"
            id="exampleInputPassword1"
            placeholder="Password"
          />
        </div>
        <div class="form-group">
          <label for="exampleInputPassword2">Retype password</label>
          <input
            type="password"
            class="form-control"
            id="exampleInputPassword2"
            placeholder="Retype Password"
          />
        </div>
        <button type="submit" class="mt-2 h-btn h-btn-primary w-100">Đăng ký</button>
        <p class="mt-1">
          Khi đăng ký, bạn đã đồng ý với Điều khoản sử dụng và Chính sách bảo mật của
          chúng tôi.
        </p>
        <div class="center-content flex-column">
          <p class="mb-1">
            Bạn đã có tài khoản?
            <a v-on:click="goToLogin" href="#">Đăng nhập</a>
          </p>
          <a href="">Quên mật khẩu?</a>
        </div>
      </form>
    </div>
  </div>
</template>
<script>
import Brand from "@/components/Brand";
import AccountMixin from "@/mixins/accountMixin.vue";

export default {
  components: {
    Brand,
  },
  mounted() {
    // Focus first tab
    var vm = this;
    this.$nextTick(function () {
      setTimeout(function () {
        vm.$refs.emailInput.focus();
      }, 100);
    });
  },
  mixins: [AccountMixin],
};
</script>
<style lang="scss" scoped>
#register {
  padding: 36px 0;
  background-color: $color-bg;
  height: 100vh;
  overflow: auto;
  .register-form {
    width: 500px;
    padding: 24px;
    background-color: $color-white;
    border-radius: $border-radius;
  }
}

::v-deep {
  .brand {
    color: black;
  }
}
</style>
