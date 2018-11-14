<template>
  <div class="home">
    <img alt="Vue logo" src="../assets/logo.png">
   

    <div>
    <button @click="getAllCats">Get cats!</button>
    </div>

    <div v-for="cat in cats" :key="cat.id">
      <h1>{{cat.name}}</h1>
      <p>{{cat.description}}</p>
    </div>

  </div>
</template>

<script>
// @ is an alias to /src
import HelloWorld from "@/components/HelloWorld.vue";

export default {
  name: "home",
  components: {
    HelloWorld
  },
  methods: {
    getAllCats() {
      this.$store.dispatch("getCats");
    }
  },
  computed: {
    cats() {
      return this.$store.state.cats;
    }
  }
};
</script>
