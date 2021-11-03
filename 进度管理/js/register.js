const item = document.querySelectorAll(".i");
const content = document.querySelectorAll(".c");
// 实现选项卡切换
for (let i = 0; i < item.length; i++) {
  item[i].addEventListener("click", () => {
    item[i].className = "i active";
    content[i].className = "c active";
    for (let j = 0; j < item.length; j++) {
      if (j != i) {
        item[j].className = "i";
        content[j].className = "c";
      }
    }
  });
}
// 为输入框添加防抖
const inp = document.querySelectorAll(".t");
function gett() {
  console.log(inp[0].value);
}
function debounce(func, delay) {
  let timer;
  let context = this;
  let args = arguments;

  return function () {
    if (timer) {
      clearTimeout(timer);
    }
    timer = setTimeout(function () {
      func.apply(context, args);
    }, delay);
  };
}
inp[0].addEventListener("input", debounce(gett, 2000));
// for (let i = 0; i < inp.length; i++) {
//   inp[0].addEventListener("input", debounce(gett, 9000));
// }
