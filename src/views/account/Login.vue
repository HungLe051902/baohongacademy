<template>
  <div id="login" class="d-flex align-items-center flex-column">
    <Brand />
    <p class="fs20p">Đăng nhập vào BaoHongAcademy</p>
    <div class="login-form">
      <form>
        <div class="form-group">
          <label for="exampleInputEmail1">Email address</label>
          <input
            ref="emailInput"
            type="email"
            class="form-control"
            id="exampleInputEmail1"
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
        <div class="form-check">
          <input
            class="form-check-input"
            type="checkbox"
            v-model="loginKeeping"
            id="flexCheckDefault"
          />
          <label class="form-check-label" for="flexCheckDefault">
            Duy trì đăng nhập
          </label>
        </div>
        <button type="submit" class="mt-2 h-btn h-btn-primary w-100">Đăng nhập</button>
        <div class="mt-3 center-content flex-column">
          <p class="mb-3">
            Bạn chưa có tài khoản?
            <a v-on:click="goToRegister" href="#">Đăng ký</a>
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
  data() {
    return {
      loginKeeping: false,
    };
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
  components: {
    Brand,
  },
  mixins: [AccountMixin],
};
</script>
<style lang="scss" scoped>
#login {
  padding: 36px 0;
  background-color: $color-bg;
  height: 100vh;
  overflow: auto;
  .login-form {
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
