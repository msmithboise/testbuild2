import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {

  },
  mutations: {

  },
  actions: {
    getBlogPosts() {
      butter.post
        .list({
          page: 1,
          page_size: 10
        })
        .then(res => {
          console.log(res.data);
          this.posts = res.data.data;
        });
    }
  }
})
