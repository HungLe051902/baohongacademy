<template>
  <div class="m-4">
    <h1>Guideline</h1>

    <h5>Dropdown</h5>

    <div class="dropdown">
      <button
        class="btn btn-secondary dropdown-toggle"
        type="button"
        id="dropdownMenuButton"
        data-toggle="dropdown"
        aria-haspopup="true"
        aria-expanded="false"
      >
        Dropdown button
      </button>
      <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
        <a class="dropdown-item" href="#">Action</a>
        <a class="dropdown-item" href="#">Another action</a>
        <a class="dropdown-item" href="#">Something else here</a>
      </div>
    </div>

    <p>------------</p>

    <div class="container">
      <h2>Pagination</h2>
      <p>The .pagination class provides pagination links:</p>
      <ul class="pagination">
        <li><a href="#">1</a></li>
        <li><a href="#">2</a></li>
        <li><a href="#">3</a></li>
        <li><a href="#">4</a></li>
        <li><a href="#">5</a></li>
      </ul>
    </div>
  </div>
</template>
<script>
// import $ from "jquery";

export default {
  methods: {
    haha() {
      console.log("hjiwerewr");
    },
  },
};
</script>
<style lang="scss"></style>
