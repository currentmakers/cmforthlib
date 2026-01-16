\
\ @file ramcfg_s.fs
\ @brief SRAM configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RAMCFG AXISRAM1 control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000100 constant RAMCFG_S_RAMCFG_AXISRAM1CR_SRAMER                \ SRAM erase.


\
\ @brief RAMCFG AXISRAM1 interrupt status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000100 constant RAMCFG_S_RAMCFG_AXISRAM1ISR_SRAMBUSY             \ SRAM busy with erase operation


\
\ @brief RAMCFG AXISRAM1 erase key register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_S_RAMCFG_AXISRAM1ERKEYR_ERASEKEY          \ Erase write protection key


\
\ @brief RAMCFG AXISRAM2 control register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000100 constant RAMCFG_S_RAMCFG_AXISRAM2CR_SRAMER                \ SRAM erase
$00100000 constant RAMCFG_S_RAMCFG_AXISRAM2CR_SRAMSD                \ Shutdown AXISRAMx


\
\ @brief RAMCFG AXISRAM2 interrupt status register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000100 constant RAMCFG_S_RAMCFG_AXISRAM2ISR_SRAMBUSY             \ SRAM busy with erase operation


\
\ @brief RAMCFG AXISRAM2 erase key register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_S_RAMCFG_AXISRAM2ERKEYR_ERASEKEY          \ Erase write protection key


\
\ @brief RAMCFG AXISRAM3 control register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000100 constant RAMCFG_S_RAMCFG_AXISRAM3CR_SRAMER                \ SRAM erase
$00100000 constant RAMCFG_S_RAMCFG_AXISRAM3CR_SRAMSD                \ Shutdown AXISRAMx


\
\ @brief RAMCFG AXISRAM3 interrupt status register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000100 constant RAMCFG_S_RAMCFG_AXISRAM3ISR_SRAMBUSY             \ SRAM busy with erase operation


\
\ @brief RAMCFG AXISRAM3 erase key register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_S_RAMCFG_AXISRAM3ERKEYR_ERASEKEY          \ Erase write protection key


\
\ @brief RAMCFG AXISRAM4 control register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000100 constant RAMCFG_S_RAMCFG_AXISRAM4CR_SRAMER                \ SRAM erase
$00100000 constant RAMCFG_S_RAMCFG_AXISRAM4CR_SRAMSD                \ Shutdown AXISRAMx


\
\ @brief RAMCFG AXISRAM4 interrupt status register
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$00000100 constant RAMCFG_S_RAMCFG_AXISRAM4ISR_SRAMBUSY             \ SRAM busy with erase operation


\
\ @brief RAMCFG AXISRAM4 erase key register
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_S_RAMCFG_AXISRAM4ERKEYR_ERASEKEY          \ Erase write protection key


\
\ @brief RAMCFG AXISRAM5 control register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000100 constant RAMCFG_S_RAMCFG_AXISRAM5CR_SRAMER                \ SRAM erase
$00100000 constant RAMCFG_S_RAMCFG_AXISRAM5CR_SRAMSD                \ Shutdown AXISRAMx


\
\ @brief RAMCFG AXISRAM5 interrupt status register
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000100 constant RAMCFG_S_RAMCFG_AXISRAM5ISR_SRAMBUSY             \ SRAM busy with erase operation


\
\ @brief RAMCFG AXISRAM5 erase key register
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_S_RAMCFG_AXISRAM5ERKEYR_ERASEKEY          \ Erase write protection key


\
\ @brief RAMCFG AXISRAM6 control register
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$00000100 constant RAMCFG_S_RAMCFG_AXISRAM6CR_SRAMER                \ SRAM erase
$00100000 constant RAMCFG_S_RAMCFG_AXISRAM6CR_SRAMSD                \ Shutdown AXISRAMx


\
\ @brief RAMCFG AXISRAM6 interrupt status register
\ Address offset: 0x288
\ Reset value: 0x00000000
\

$00000100 constant RAMCFG_S_RAMCFG_AXISRAM6ISR_SRAMBUSY             \ SRAM busy with erase operation


\
\ @brief RAMCFG AXISRAM6 erase key register
\ Address offset: 0x2A8
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_S_RAMCFG_AXISRAM6ERKEYR_ERASEKEY          \ Erase write protection key


\
\ @brief RAMCFG AHBSRAM1 control register
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000100 constant RAMCFG_S_RAMCFG_AHBSRAM1CR_SRAMER                \ SRAM erase


\
\ @brief RAMCFG AHBSRAM1 interrupt status register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$00000100 constant RAMCFG_S_RAMCFG_AHBSRAM1ISR_SRAMBUSY             \ SRAM busy with erase operation


\
\ @brief RAMCFG AHBSRAM1 erase key register
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_S_RAMCFG_AHBSRAM1ERKEYR_ERASEKEY          \ Erase write protection key


\
\ @brief RAMCFG AHBSRAM2 control register
\ Address offset: 0x380
\ Reset value: 0x00000000
\

$00000100 constant RAMCFG_S_RAMCFG_AHBSRAM2CR_SRAMER                \ SRAM erase


\
\ @brief RAMCFG AHBSRAM2 interrupt status register
\ Address offset: 0x388
\ Reset value: 0x00000000
\

$00000100 constant RAMCFG_S_RAMCFG_AHBSRAM2ISR_SRAMBUSY             \ SRAM busy with erase operation


\
\ @brief RAMCFG AHBSRAM2 erase key register
\ Address offset: 0x3A8
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_S_RAMCFG_AHBSRAM2ERKEYR_ERASEKEY          \ Erase write protection key


\
\ @brief RAMCFG VENCRAM control register
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$00000100 constant RAMCFG_S_RAMCFG_VENCRAMCR_SRAMER                 \ SRAM erase


\
\ @brief RAMCFG VENCRAM interrupt status register
\ Address offset: 0x408
\ Reset value: 0x00000000
\

$00000100 constant RAMCFG_S_RAMCFG_VENCRAMISR_SRAMBUSY              \ SRAM busy with erase operation


\
\ @brief RAMCFG VENCRAM erase key register
\ Address offset: 0x428
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_S_RAMCFG_VENCRAMERKEYR_ERASEKEY           \ Erase write protection key


\
\ @brief RAMCFG BKPSRAM control register
\ Address offset: 0x480
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_S_RAMCFG_BKPSRAMCR_ECCE                   \ ECC enable
$00000010 constant RAMCFG_S_RAMCFG_BKPSRAMCR_ALE                    \ Address latch enable
$00000100 constant RAMCFG_S_RAMCFG_BKPSRAMCR_SRAMER                 \ SRAM erase


\
\ @brief RAMCFG BKPSRAM interrupt enable register
\ Address offset: 0x484
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_S_RAMCFG_BKPSRAMIER_SEIE                  \ ECC single error interrupt enable
$00000002 constant RAMCFG_S_RAMCFG_BKPSRAMIER_DEIE                  \ ECC double error interrupt enable


\
\ @brief RAMCFG BKPSRAM interrupt status register
\ Address offset: 0x488
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_S_RAMCFG_BKPSRAMISR_SEC                   \ ECC single error detected
$00000002 constant RAMCFG_S_RAMCFG_BKPSRAMISR_DED                   \ ECC double-error interrupt enable
$00000100 constant RAMCFG_S_RAMCFG_BKPSRAMISR_SRAMBUSY              \ SRAM busy with erase operation


\
\ @brief RAMCFG BKPSRAM single error address register
\ Address offset: 0x48C
\ Reset value: 0x00000000
\

$000007ff constant RAMCFG_S_RAMCFG_BKPSRAMESEAR_ESEA                \ ECC single error address


\
\ @brief RAMCFG BKPSRAM double error address register
\ Address offset: 0x490
\ Reset value: 0x00000000
\

$000007ff constant RAMCFG_S_RAMCFG_BKPSRAMEDEAR_EDEA                \ ECC double error address


\
\ @brief RAMCFG BKPSRAM interrupt clear register
\ Address offset: 0x494
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_S_RAMCFG_BKPSRAMICR_CSED                  \ Clear ECC single-error interrupt
$00000002 constant RAMCFG_S_RAMCFG_BKPSRAMICR_CDED                  \ Clear ECC double-error interrupt


\
\ @brief RAMCFG BKPSRAM ECC key register
\ Address offset: 0x4A4
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_S_RAMCFG_BKPSRAMECCKEYR_ECCKEY            \ ECC write protection key


\
\ @brief RAMCFG BKPSRAM erase key register
\ Address offset: 0x4A8
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_S_RAMCFG_BKPSRAMERKEYR_ERASEKEY           \ Erase write protection key


\
\ @brief RAMCFG FLEXRAM control register
\ Address offset: 0x500
\ Reset value: 0x00000000
\

$00000100 constant RAMCFG_S_RAMCFG_FLEXRAMCR_SRAMER                 \ SRAM erase
$00001000 constant RAMCFG_S_RAMCFG_FLEXRAMCR_SRAMHWERDIS            \ SRAM hardware erase disable
$00030000 constant RAMCFG_S_RAMCFG_FLEXRAMCR_ITCMCFG                \ Configuration of the FLEXMEM I-TCM extension
$01000000 constant RAMCFG_S_RAMCFG_FLEXRAMCR_DTCMCFG                \ Configuration of the FLEXMEM D-TCM extension


\
\ @brief RAMCFG FLEXRAM interrupt status register
\ Address offset: 0x508
\ Reset value: 0x00000000
\

$00000100 constant RAMCFG_S_RAMCFG_FLEXRAMISR_SRAMBUSY              \ SRAM busy with erase operation


\
\ @brief RAMCFG FLEXRAM erase key register
\ Address offset: 0x528
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_S_RAMCFG_FLEXRAMERKEYR_ERASEKEY           \ Erase write protection key


\
\ @brief SRAM configuration controller
\
$52023000 constant RAMCFG_S_RAMCFG_AXISRAM1CR  \ offset: 0x00 : RAMCFG AXISRAM1 control register
$52023008 constant RAMCFG_S_RAMCFG_AXISRAM1ISR  \ offset: 0x08 : RAMCFG AXISRAM1 interrupt status register
$52023028 constant RAMCFG_S_RAMCFG_AXISRAM1ERKEYR  \ offset: 0x28 : RAMCFG AXISRAM1 erase key register
$52023080 constant RAMCFG_S_RAMCFG_AXISRAM2CR  \ offset: 0x80 : RAMCFG AXISRAM2 control register
$52023088 constant RAMCFG_S_RAMCFG_AXISRAM2ISR  \ offset: 0x88 : RAMCFG AXISRAM2 interrupt status register
$520230a8 constant RAMCFG_S_RAMCFG_AXISRAM2ERKEYR  \ offset: 0xA8 : RAMCFG AXISRAM2 erase key register
$52023100 constant RAMCFG_S_RAMCFG_AXISRAM3CR  \ offset: 0x100 : RAMCFG AXISRAM3 control register
$52023108 constant RAMCFG_S_RAMCFG_AXISRAM3ISR  \ offset: 0x108 : RAMCFG AXISRAM3 interrupt status register
$52023128 constant RAMCFG_S_RAMCFG_AXISRAM3ERKEYR  \ offset: 0x128 : RAMCFG AXISRAM3 erase key register
$52023180 constant RAMCFG_S_RAMCFG_AXISRAM4CR  \ offset: 0x180 : RAMCFG AXISRAM4 control register
$52023188 constant RAMCFG_S_RAMCFG_AXISRAM4ISR  \ offset: 0x188 : RAMCFG AXISRAM4 interrupt status register
$520231a8 constant RAMCFG_S_RAMCFG_AXISRAM4ERKEYR  \ offset: 0x1A8 : RAMCFG AXISRAM4 erase key register
$52023200 constant RAMCFG_S_RAMCFG_AXISRAM5CR  \ offset: 0x200 : RAMCFG AXISRAM5 control register
$52023208 constant RAMCFG_S_RAMCFG_AXISRAM5ISR  \ offset: 0x208 : RAMCFG AXISRAM5 interrupt status register
$52023228 constant RAMCFG_S_RAMCFG_AXISRAM5ERKEYR  \ offset: 0x228 : RAMCFG AXISRAM5 erase key register
$52023280 constant RAMCFG_S_RAMCFG_AXISRAM6CR  \ offset: 0x280 : RAMCFG AXISRAM6 control register
$52023288 constant RAMCFG_S_RAMCFG_AXISRAM6ISR  \ offset: 0x288 : RAMCFG AXISRAM6 interrupt status register
$520232a8 constant RAMCFG_S_RAMCFG_AXISRAM6ERKEYR  \ offset: 0x2A8 : RAMCFG AXISRAM6 erase key register
$52023300 constant RAMCFG_S_RAMCFG_AHBSRAM1CR  \ offset: 0x300 : RAMCFG AHBSRAM1 control register
$52023308 constant RAMCFG_S_RAMCFG_AHBSRAM1ISR  \ offset: 0x308 : RAMCFG AHBSRAM1 interrupt status register
$52023328 constant RAMCFG_S_RAMCFG_AHBSRAM1ERKEYR  \ offset: 0x328 : RAMCFG AHBSRAM1 erase key register
$52023380 constant RAMCFG_S_RAMCFG_AHBSRAM2CR  \ offset: 0x380 : RAMCFG AHBSRAM2 control register
$52023388 constant RAMCFG_S_RAMCFG_AHBSRAM2ISR  \ offset: 0x388 : RAMCFG AHBSRAM2 interrupt status register
$520233a8 constant RAMCFG_S_RAMCFG_AHBSRAM2ERKEYR  \ offset: 0x3A8 : RAMCFG AHBSRAM2 erase key register
$52023400 constant RAMCFG_S_RAMCFG_VENCRAMCR  \ offset: 0x400 : RAMCFG VENCRAM control register
$52023408 constant RAMCFG_S_RAMCFG_VENCRAMISR  \ offset: 0x408 : RAMCFG VENCRAM interrupt status register
$52023428 constant RAMCFG_S_RAMCFG_VENCRAMERKEYR  \ offset: 0x428 : RAMCFG VENCRAM erase key register
$52023480 constant RAMCFG_S_RAMCFG_BKPSRAMCR  \ offset: 0x480 : RAMCFG BKPSRAM control register
$52023484 constant RAMCFG_S_RAMCFG_BKPSRAMIER  \ offset: 0x484 : RAMCFG BKPSRAM interrupt enable register
$52023488 constant RAMCFG_S_RAMCFG_BKPSRAMISR  \ offset: 0x488 : RAMCFG BKPSRAM interrupt status register
$5202348c constant RAMCFG_S_RAMCFG_BKPSRAMESEAR  \ offset: 0x48C : RAMCFG BKPSRAM single error address register
$52023490 constant RAMCFG_S_RAMCFG_BKPSRAMEDEAR  \ offset: 0x490 : RAMCFG BKPSRAM double error address register
$52023494 constant RAMCFG_S_RAMCFG_BKPSRAMICR  \ offset: 0x494 : RAMCFG BKPSRAM interrupt clear register
$520234a4 constant RAMCFG_S_RAMCFG_BKPSRAMECCKEYR  \ offset: 0x4A4 : RAMCFG BKPSRAM ECC key register
$520234a8 constant RAMCFG_S_RAMCFG_BKPSRAMERKEYR  \ offset: 0x4A8 : RAMCFG BKPSRAM erase key register
$52023500 constant RAMCFG_S_RAMCFG_FLEXRAMCR  \ offset: 0x500 : RAMCFG FLEXRAM control register
$52023508 constant RAMCFG_S_RAMCFG_FLEXRAMISR  \ offset: 0x508 : RAMCFG FLEXRAM interrupt status register
$52023528 constant RAMCFG_S_RAMCFG_FLEXRAMERKEYR  \ offset: 0x528 : RAMCFG FLEXRAM erase key register

