/**
 *
 * @module  formatTool
 */

var tool = {
    /**
     * 資料夾：取得下層檔案
     * 檔案：去除附檔名，且去除重複名稱檔案
     * @function getFolderViewJson
     * @param dirList {Object}
     * @param dirList.Name {String} 檔案名稱
     * @param dirList.Path {String} 檔案路徑
     * @param dirList.IsFolder {Boolean} 是否為資料夾
     * @param dirList.ChildList {Object} 子層資料結構
     */
    getFolderViewJson: (dirList) => {
        // 是檔案 過濾掉 多語言的重複檔案
        var root = (list) => {
            return list.filter((item) => {
                if (item.IsFolder) {
                    item.ChildList = root(item.ChildList);
                    return true;
                } else {
                    return item.Name.split('.').length === 1;
                }
            });
        }
        return root(dirList);
    },

    /**
     * 將xml轉過的json再整理成前端好解析的格式
     * @function getFileViewJson
     * @param languageList {Object}
     * @param languageList.Name {String}
     * @param languageList.Language {String}
     * @param languageList.Data {Object}
     * @returns {Array}
     */
    getFileViewJson: (languageList) => {
        return languageList.map((languageItem) => {
            languageItem.Data = languageItem.Data.map((item) => {

                return {
                    Key: item.$.name,
                    Val: item.value[0]
                }
            });
            return languageItem;
        });
    }
};

module.exports = tool;