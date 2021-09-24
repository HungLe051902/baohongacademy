<template>
  <div id="landingpage">
    <div
      id="landingpage-header"
      class="d-flex justify-content-between align-items-center"
    >
      <div class="menu" id="landingpage-header-left">
        <div class="menu-item">Giới thiệu</div>
        <div class="menu-item">Khóa học</div>
        <div class="menu-item">Hỏi đáp</div>
        <div class="menu-item">Bài viết</div>
        <div class="menu-item">Tài trợ</div>
        <div class="menu-item">Liên hệ</div>
      </div>
      <div id="landingpage-header-right" class="d-flex">
        <div></div>
        <div class="account">
          <img class="avatar" src="" alt="" />
          <span style="font-weight: bold">Tài khoản</span>
        </div>
      </div>
    </div>
    <div id="landingpage-content">
      <div class="w-100 h-100 d-flex">
        <div class="w-50 d-flex justify-content-center align-items-center">
          <div class="brand">BaoHongAcademy</div>
        </div>
        <div class="w-50">
          <div class="landingpage-intro"></div>
        </div>
      </div>
    </div>
    <div id="landingpage-footer"></div>
  </div>
</template>
<script>
export default {};
</script>
<style lang="scss" scoped>
#landingpage {
  background-image: url("~@/assets/img/landing_page_background.jpg");
  height: 100vh;
  /* Center and scale the image nicely */
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
  #landingpage-header {
    color: #ffffff;
    height: 60px;
    background-color: #c5d5cb;
    padding: 0 24px;
    .menu {
      height: 100%;
      display: flex;
      .menu-item {
        height: 100%;
        margin-right: 16px;
        display: flex;
        align-items: center;
        font-weight: bold;
        cursor: pointer;
        &:hover {
          cursor: pointer;
          background-color: #c5d5d3;
        }
      }
    }
  }
  #landingpage-content {
    width: 100%;
    height: calc(100vh - 60px);
    .brand {
      color: $color-white;
      font-size: 50px;
      font-weight: bold;
    }
  }
}
</style>
