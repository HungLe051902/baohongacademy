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

    <h5>Base Input</h5>
    <input type="text" />
    <p>------------</p>
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
