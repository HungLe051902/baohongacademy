<template>
  <div>
    <div
      id="landingpage-header"
      class="d-flex justify-content-between align-items-center"
    >
      <div class="menu" id="landingpage-header-left">
        <div class="menu-item">Khóa học</div>
        <div class="menu-item">Bài viết</div>
        <div class="menu-item">Liên hệ</div>
      </div>
      <div id="landingpage-header-right" class="d-flex">
          <div></div>
          <div>Tài khoản</div>
      </div>
    </div>
    <div id="landingpage-content">Content</div>
    <div id="landingpage-footer">Footer</div>
  </div>
</template>
<script>
export default {};
</script>
<style lang="scss" scoped>
#landingpage-header {
  color: #FFFFFF;
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
      &:hover {
        cursor: pointer;
        background-color: #c5d5d3;
      }
    }
  }
}
</style>