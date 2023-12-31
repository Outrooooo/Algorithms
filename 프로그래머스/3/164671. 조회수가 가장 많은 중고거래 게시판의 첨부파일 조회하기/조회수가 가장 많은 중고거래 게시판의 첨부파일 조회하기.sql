-- 코드를 입력하세요
SELECT CONCAT("/home/grep/src/",USED_GOODS_FILE.BOARD_ID,"/",USED_GOODS_FILE.FILE_ID,USED_GOODS_FILE.FILE_NAME,USED_GOODS_FILE.FILE_EXT) as FILE_PATH
FROM USED_GOODS_FILE 
    JOIN USED_GOODS_BOARD 
    ON USED_GOODS_FILE.BOARD_ID = USED_GOODS_BOARD.BOARD_ID
WHERE USED_GOODS_BOARD.VIEWS = (SELECT MAX(VIEWS) FROM USED_GOODS_BOARD)
ORDER BY VIEWS DESC, FILE_ID DESC