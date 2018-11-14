import Vue from 'vue'
import Vuex from 'vuex'
import Axios from 'axios'

Vue.use(Vuex)

let api = Axios.create({
  baseURL: "//localhost:5000/api/",
  timeout: 3000,
  withCredentials: true
})

export default new Vuex.Store({
  state: {
    cats: []

  },
  mutations: {
    setCats(state, cats) {
      state.cats = cats
    }


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
    },

    getCats({ commit, dispatch }) {
      api.get('cats')
        .then(res => {
          commit('setCats', res.data)
          console.log(res.data)
        })
    }


  }
})
