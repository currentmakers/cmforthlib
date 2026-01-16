\
\ @file bsec.fs
\ @brief BSEC2
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief BSEC OTP configuration register
\ Address offset: 0x00
\ Reset value: 0x0000000E
\

$00000001 constant BSEC_BSEC_OTP_CONFIG_PWRUP                       \ PWRUP
$00000006 constant BSEC_BSEC_OTP_CONFIG_FRC                         \ FRC
$00000078 constant BSEC_BSEC_OTP_CONFIG_PRGWIDTH                    \ PRGWIDTH
$00000180 constant BSEC_BSEC_OTP_CONFIG_TREAD                       \ TREAD


\
\ @brief BSEC OTP control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000007f constant BSEC_BSEC_OTP_CONTROL_ADDR                       \ ADDR
$00000100 constant BSEC_BSEC_OTP_CONTROL_PROG                       \ PROG
$00000200 constant BSEC_BSEC_OTP_CONTROL_LOCK                       \ LOCK


\
\ @brief BSEC OTP write data register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_WRDATA_WRDATA                      \ WRDATA


\
\ @brief BSEC OTP status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant BSEC_BSEC_OTP_STATUS_SECURE                      \ SECURE
$00000002 constant BSEC_BSEC_OTP_STATUS_FULLDBG                     \ FULLDBG
$00000004 constant BSEC_BSEC_OTP_STATUS_INVALID                     \ INVALID
$00000008 constant BSEC_BSEC_OTP_STATUS_BUSY                        \ BUSY
$00000010 constant BSEC_BSEC_OTP_STATUS_PROGFAIL                    \ PROGFAIL
$00000020 constant BSEC_BSEC_OTP_STATUS_PWRON                       \ PWRON
$00000040 constant BSEC_BSEC_OTP_STATUS_BIST1LOCK                   \ BIST1LOCK
$00000080 constant BSEC_BSEC_OTP_STATUS_BIST2LOCK                   \ BIST2LOCK


\
\ @brief BSEC OTP lock configuration register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant BSEC_BSEC_OTP_LOCK_OTP                           \ OTP
$00000002 constant BSEC_BSEC_OTP_LOCK_ROMLOCK                       \ ROMLOCK
$00000004 constant BSEC_BSEC_OTP_LOCK_DENREG                        \ DENREG
$00000010 constant BSEC_BSEC_OTP_LOCK_GPLOCK                        \ GPLOCK


\
\ @brief reset value depends on OTP secure mode according toTable18: BSEC_DENABLE default values after reset on page181.
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant BSEC_BSEC_DENABLE_DFTEN                          \ DFTEN
$00000002 constant BSEC_BSEC_DENABLE_DBGEN                          \ DBGEN
$00000004 constant BSEC_BSEC_DENABLE_NIDEN                          \ NIDEN
$00000008 constant BSEC_BSEC_DENABLE_DEVICEEN                       \ DEVICEEN
$00000010 constant BSEC_BSEC_DENABLE_HDPEN                          \ HDPEN
$00000020 constant BSEC_BSEC_DENABLE_SPIDEN                         \ SPIDEN
$00000040 constant BSEC_BSEC_DENABLE_SPNIDEN                        \ SPNIDEN
$00000180 constant BSEC_BSEC_DENABLE_CP15SDISABLE                   \ CP15SDISABLE
$00000200 constant BSEC_BSEC_DENABLE_CFGSDISABLE                    \ CFGSDISABLE
$00000400 constant BSEC_BSEC_DENABLE_DBGSWENABLE                    \ DBGSWENABLE


\
\ @brief BSEC_OTP_DISTURBED0 is used to report disturbed state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP). BSEC_OTP_DISTURBED1 is used to report disturbed state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_DISTURBED2 is used to report disturbed state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95.
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DISTURBED0_DIS                     \ DIS


\
\ @brief BSEC_OTP_DISTURBED0 is used to report disturbed state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP). BSEC_OTP_DISTURBED1 is used to report disturbed state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_DISTURBED2 is used to report disturbed state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95.
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DISTURBED1_DIS                     \ DIS


\
\ @brief BSEC_OTP_DISTURBED0 is used to report disturbed state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP). BSEC_OTP_DISTURBED1 is used to report disturbed state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_DISTURBED2 is used to report disturbed state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95.
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DISTURBED2_DIS                     \ DIS


\
\ @brief BSEC_OTP_ERROR0 is used to report error state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP which are protected by 2:1 redundancy). BSEC_OTP_ERROR1 is used to report error state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 which are protected by 6-bit ECC. BSEC_OTP_ERROR2 is used to report error state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 which are protected by 6-bit ECC.
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_ERROR0_ERR                         \ ERR


\
\ @brief BSEC_OTP_ERROR0 is used to report error state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP which are protected by 2:1 redundancy). BSEC_OTP_ERROR1 is used to report error state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 which are protected by 6-bit ECC. BSEC_OTP_ERROR2 is used to report error state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 which are protected by 6-bit ECC.
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_ERROR1_ERR                         \ ERR


\
\ @brief BSEC_OTP_ERROR0 is used to report error state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP which are protected by 2:1 redundancy). BSEC_OTP_ERROR1 is used to report error state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 which are protected by 6-bit ECC. BSEC_OTP_ERROR2 is used to report error state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 which are protected by 6-bit ECC.
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_ERROR2_ERR                         \ ERR


\
\ @brief BSEC_OTP_WLOCK0 is used to report permanent write lock of BSEC_OTP_DATA0 to BSEC_OTP_DATA31. BSEC_OTP_WLOCK1 is used to report permanent write lock of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_WLOCK2 is used to report permanent write lock of BSEC_OTP_DATA64 to BSEC_OTP_DATA95. Permanent write lock requires a programming sequence to lock a word (see section:Section3.3.6: OTP operations on page178).
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_WRLOCK0_WRLOCK                     \ WRLOCK


\
\ @brief BSEC_OTP_WLOCK0 is used to report permanent write lock of BSEC_OTP_DATA0 to BSEC_OTP_DATA31. BSEC_OTP_WLOCK1 is used to report permanent write lock of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_WLOCK2 is used to report permanent write lock of BSEC_OTP_DATA64 to BSEC_OTP_DATA95. Permanent write lock requires a programming sequence to lock a word (see section:Section3.3.6: OTP operations on page178).
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_WRLOCK1_WRLOCK                     \ WRLOCK


\
\ @brief BSEC_OTP_WLOCK0 is used to report permanent write lock of BSEC_OTP_DATA0 to BSEC_OTP_DATA31. BSEC_OTP_WLOCK1 is used to report permanent write lock of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_WLOCK2 is used to report permanent write lock of BSEC_OTP_DATA64 to BSEC_OTP_DATA95. Permanent write lock requires a programming sequence to lock a word (see section:Section3.3.6: OTP operations on page178).
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_WRLOCK2_WRLOCK                     \ WRLOCK


\
\ @brief BSEC_OTP_SPLOCK0 is used to lock the programming of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset BSEC_OTP_SPLOCK1 is used to lock the programming of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset BSEC_OTP_SPLOCK2 is used to lock the programming of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset Attempt to sticky program locked OTP word are silently ignored.
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_SPLOCK0_SPLOCK                     \ SPLOCK


\
\ @brief BSEC_OTP_SPLOCK0 is used to lock the programming of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset BSEC_OTP_SPLOCK1 is used to lock the programming of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset BSEC_OTP_SPLOCK2 is used to lock the programming of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset Attempt to sticky program locked OTP word are silently ignored.
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_SPLOCK1_SPLOCK                     \ SPLOCK


\
\ @brief BSEC_OTP_SPLOCK0 is used to lock the programming of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset BSEC_OTP_SPLOCK1 is used to lock the programming of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset BSEC_OTP_SPLOCK2 is used to lock the programming of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset Attempt to sticky program locked OTP word are silently ignored.
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_SPLOCK2_SPLOCK                     \ SPLOCK


\
\ @brief BSEC_OTP_SWLOCK0 is used to prevent writing to BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SWLOCK1 is used to prevent writing to BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SWLOCK2 is used to prevent writing to BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Write to shadow write locked BSEC_OTP_DATA word are silently ignored. Writing to OTP word 0 shadow is always prevented.
\ Address offset: 0x7C
\ Reset value: 0x00000001
\

$00000000 constant BSEC_BSEC_OTP_SWLOCK0_SWLOCK                     \ SWLOCK


\
\ @brief BSEC_OTP_SWLOCK0 is used to prevent writing to BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SWLOCK1 is used to prevent writing to BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SWLOCK2 is used to prevent writing to BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Write to shadow write locked BSEC_OTP_DATA word are silently ignored. Writing to OTP word 0 shadow is always prevented.
\ Address offset: 0x80
\ Reset value: 0x00000001
\

$00000000 constant BSEC_BSEC_OTP_SWLOCK1_SWLOCK                     \ SWLOCK


\
\ @brief BSEC_OTP_SWLOCK0 is used to prevent writing to BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SWLOCK1 is used to prevent writing to BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SWLOCK2 is used to prevent writing to BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Write to shadow write locked BSEC_OTP_DATA word are silently ignored. Writing to OTP word 0 shadow is always prevented.
\ Address offset: 0x84
\ Reset value: 0x00000001
\

$00000000 constant BSEC_BSEC_OTP_SWLOCK2_SWLOCK                     \ SWLOCK


\
\ @brief BSEC_OTP_SRLOCK0 is used to prevent reloading of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SRLOCK1 is used to prevent reloading of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SRLOCK2 is used to prevent reloading of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Setting SRLOCK bits or attempt to reload a locked OTP do not clear the corresponding BSEC_OTP_DATAx shadow register. BSEC_OTP_SRLOCK0 bit 0 is controlled by hardware according to fuse_ok, writing to this bit has no effect.
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_SRLOCK0_SRLOCK                     \ SRLOCK


\
\ @brief BSEC_OTP_SRLOCK0 is used to prevent reloading of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SRLOCK1 is used to prevent reloading of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SRLOCK2 is used to prevent reloading of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Setting SRLOCK bits or attempt to reload a locked OTP do not clear the corresponding BSEC_OTP_DATAx shadow register. BSEC_OTP_SRLOCK0 bit 0 is controlled by hardware according to fuse_ok, writing to this bit has no effect.
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_SRLOCK1_SRLOCK                     \ SRLOCK


\
\ @brief BSEC_OTP_SRLOCK0 is used to prevent reloading of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SRLOCK1 is used to prevent reloading of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SRLOCK2 is used to prevent reloading of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Setting SRLOCK bits or attempt to reload a locked OTP do not clear the corresponding BSEC_OTP_DATAx shadow register. BSEC_OTP_SRLOCK0 bit 0 is controlled by hardware according to fuse_ok, writing to this bit has no effect.
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_SRLOCK2_SRLOCK                     \ SRLOCK


\
\ @brief BSEC JTAG input register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$0000ffff constant BSEC_BSEC_JTAGIN_DATA                            \ DATA


\
\ @brief BSEC JTAG output register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$0000ffff constant BSEC_BSEC_JTAGOUT_DATA                           \ DATA


\
\ @brief BSEC scratch register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_SCRATCH_DATA                           \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA0_DATA                         \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA1_DATA                         \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA2_DATA                         \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA3_DATA                         \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA4_DATA                         \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA5_DATA                         \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA6_DATA                         \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA7_DATA                         \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA8_DATA                         \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA9_DATA                         \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA10_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA11_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x230
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA12_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x234
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA13_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x238
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA14_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x23C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA15_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x240
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA16_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x244
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA17_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x248
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA18_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x24C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA19_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA20_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x254
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA21_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x258
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA22_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x25C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA23_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x260
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA24_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x264
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA25_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x268
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA26_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x26C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA27_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x270
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA28_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x274
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA29_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x278
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA30_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x27C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA31_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA32_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA33_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x288
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA34_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x28C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA35_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x290
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA36_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x294
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA37_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x298
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA38_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x29C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA39_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2A0
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA40_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2A4
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA41_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2A8
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA42_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2AC
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA43_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2B0
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA44_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2B4
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA45_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2B8
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA46_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2BC
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA47_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2C0
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA48_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2C4
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA49_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2C8
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA50_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2CC
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA51_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2D0
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA52_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2D4
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA53_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2D8
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA54_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2DC
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA55_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2E0
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA56_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2E4
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA57_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2E8
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA58_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2EC
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA59_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2F0
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA60_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2F4
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA61_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2F8
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA62_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x2FC
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA63_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA64_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA65_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA66_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x30C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA67_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA68_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA69_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA70_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA71_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA72_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x324
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA73_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA74_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x32C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA75_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x330
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA76_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x334
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA77_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x338
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA78_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x33C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA79_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x340
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA80_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x344
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA81_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x348
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA82_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x34C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA83_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x350
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA84_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x354
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA85_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x358
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA86_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x35C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA87_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x360
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA88_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x364
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA89_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x368
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA90_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x36C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA91_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x370
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA92_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x374
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA93_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x378
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA94_DATA                        \ DATA


\
\ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
\ Address offset: 0x37C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA95_DATA                        \ DATA


\
\ @brief BSEC hardware configuration register
\ Address offset: 0xFF0
\ Reset value: 0x00000014
\

$0000000f constant BSEC_BSEC_HWCFGR_SIZE                            \ SIZE
$000000f0 constant BSEC_BSEC_HWCFGR_ECC_USE                         \ ECC_USE


\
\ @brief BSEC version register
\ Address offset: 0xFF4
\ Reset value: 0x00000011
\

$0000000f constant BSEC_BSEC_VERR_MINREV                            \ MINREV
$000000f0 constant BSEC_BSEC_VERR_MAJREV                            \ MAJREV


\
\ @brief BSEC identification register
\ Address offset: 0xFF8
\ Reset value: 0x00100032
\

$00000000 constant BSEC_BSEC_IPIDR_ID                               \ ID


\
\ @brief BSEC size identification register
\ Address offset: 0xFFC
\ Reset value: 0xA3C5DD04
\

$00000000 constant BSEC_BSEC_SIDR_SID                               \ SID


\
\ @brief BSEC2
\
$5c005000 constant BSEC_BSEC_OTP_CONFIG  \ offset: 0x00 : BSEC OTP configuration register
$5c005004 constant BSEC_BSEC_OTP_CONTROL  \ offset: 0x04 : BSEC OTP control register
$5c005008 constant BSEC_BSEC_OTP_WRDATA  \ offset: 0x08 : BSEC OTP write data register
$5c00500c constant BSEC_BSEC_OTP_STATUS  \ offset: 0x0C : BSEC OTP status register
$5c005010 constant BSEC_BSEC_OTP_LOCK  \ offset: 0x10 : BSEC OTP lock configuration register
$5c005014 constant BSEC_BSEC_DENABLE  \ offset: 0x14 : reset value depends on OTP secure mode according toTable18: BSEC_DENABLE default values after reset on page181.
$5c00501c constant BSEC_BSEC_OTP_DISTURBED0  \ offset: 0x1C : BSEC_OTP_DISTURBED0 is used to report disturbed state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP). BSEC_OTP_DISTURBED1 is used to report disturbed state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_DISTURBED2 is used to report disturbed state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95.
$5c005020 constant BSEC_BSEC_OTP_DISTURBED1  \ offset: 0x20 : BSEC_OTP_DISTURBED0 is used to report disturbed state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP). BSEC_OTP_DISTURBED1 is used to report disturbed state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_DISTURBED2 is used to report disturbed state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95.
$5c005024 constant BSEC_BSEC_OTP_DISTURBED2  \ offset: 0x24 : BSEC_OTP_DISTURBED0 is used to report disturbed state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP). BSEC_OTP_DISTURBED1 is used to report disturbed state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_DISTURBED2 is used to report disturbed state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95.
$5c005034 constant BSEC_BSEC_OTP_ERROR0  \ offset: 0x34 : BSEC_OTP_ERROR0 is used to report error state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP which are protected by 2:1 redundancy). BSEC_OTP_ERROR1 is used to report error state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 which are protected by 6-bit ECC. BSEC_OTP_ERROR2 is used to report error state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 which are protected by 6-bit ECC.
$5c005038 constant BSEC_BSEC_OTP_ERROR1  \ offset: 0x38 : BSEC_OTP_ERROR0 is used to report error state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP which are protected by 2:1 redundancy). BSEC_OTP_ERROR1 is used to report error state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 which are protected by 6-bit ECC. BSEC_OTP_ERROR2 is used to report error state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 which are protected by 6-bit ECC.
$5c00503c constant BSEC_BSEC_OTP_ERROR2  \ offset: 0x3C : BSEC_OTP_ERROR0 is used to report error state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP which are protected by 2:1 redundancy). BSEC_OTP_ERROR1 is used to report error state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 which are protected by 6-bit ECC. BSEC_OTP_ERROR2 is used to report error state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 which are protected by 6-bit ECC.
$5c00504c constant BSEC_BSEC_OTP_WRLOCK0  \ offset: 0x4C : BSEC_OTP_WLOCK0 is used to report permanent write lock of BSEC_OTP_DATA0 to BSEC_OTP_DATA31. BSEC_OTP_WLOCK1 is used to report permanent write lock of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_WLOCK2 is used to report permanent write lock of BSEC_OTP_DATA64 to BSEC_OTP_DATA95. Permanent write lock requires a programming sequence to lock a word (see section:Section3.3.6: OTP operations on page178).
$5c005050 constant BSEC_BSEC_OTP_WRLOCK1  \ offset: 0x50 : BSEC_OTP_WLOCK0 is used to report permanent write lock of BSEC_OTP_DATA0 to BSEC_OTP_DATA31. BSEC_OTP_WLOCK1 is used to report permanent write lock of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_WLOCK2 is used to report permanent write lock of BSEC_OTP_DATA64 to BSEC_OTP_DATA95. Permanent write lock requires a programming sequence to lock a word (see section:Section3.3.6: OTP operations on page178).
$5c005054 constant BSEC_BSEC_OTP_WRLOCK2  \ offset: 0x54 : BSEC_OTP_WLOCK0 is used to report permanent write lock of BSEC_OTP_DATA0 to BSEC_OTP_DATA31. BSEC_OTP_WLOCK1 is used to report permanent write lock of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_WLOCK2 is used to report permanent write lock of BSEC_OTP_DATA64 to BSEC_OTP_DATA95. Permanent write lock requires a programming sequence to lock a word (see section:Section3.3.6: OTP operations on page178).
$5c005064 constant BSEC_BSEC_OTP_SPLOCK0  \ offset: 0x64 : BSEC_OTP_SPLOCK0 is used to lock the programming of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset BSEC_OTP_SPLOCK1 is used to lock the programming of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset BSEC_OTP_SPLOCK2 is used to lock the programming of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset Attempt to sticky program locked OTP word are silently ignored.
$5c005068 constant BSEC_BSEC_OTP_SPLOCK1  \ offset: 0x68 : BSEC_OTP_SPLOCK0 is used to lock the programming of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset BSEC_OTP_SPLOCK1 is used to lock the programming of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset BSEC_OTP_SPLOCK2 is used to lock the programming of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset Attempt to sticky program locked OTP word are silently ignored.
$5c00506c constant BSEC_BSEC_OTP_SPLOCK2  \ offset: 0x6C : BSEC_OTP_SPLOCK0 is used to lock the programming of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset BSEC_OTP_SPLOCK1 is used to lock the programming of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset BSEC_OTP_SPLOCK2 is used to lock the programming of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset Attempt to sticky program locked OTP word are silently ignored.
$5c00507c constant BSEC_BSEC_OTP_SWLOCK0  \ offset: 0x7C : BSEC_OTP_SWLOCK0 is used to prevent writing to BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SWLOCK1 is used to prevent writing to BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SWLOCK2 is used to prevent writing to BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Write to shadow write locked BSEC_OTP_DATA word are silently ignored. Writing to OTP word 0 shadow is always prevented.
$5c005080 constant BSEC_BSEC_OTP_SWLOCK1  \ offset: 0x80 : BSEC_OTP_SWLOCK0 is used to prevent writing to BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SWLOCK1 is used to prevent writing to BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SWLOCK2 is used to prevent writing to BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Write to shadow write locked BSEC_OTP_DATA word are silently ignored. Writing to OTP word 0 shadow is always prevented.
$5c005084 constant BSEC_BSEC_OTP_SWLOCK2  \ offset: 0x84 : BSEC_OTP_SWLOCK0 is used to prevent writing to BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SWLOCK1 is used to prevent writing to BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SWLOCK2 is used to prevent writing to BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Write to shadow write locked BSEC_OTP_DATA word are silently ignored. Writing to OTP word 0 shadow is always prevented.
$5c005094 constant BSEC_BSEC_OTP_SRLOCK0  \ offset: 0x94 : BSEC_OTP_SRLOCK0 is used to prevent reloading of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SRLOCK1 is used to prevent reloading of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SRLOCK2 is used to prevent reloading of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Setting SRLOCK bits or attempt to reload a locked OTP do not clear the corresponding BSEC_OTP_DATAx shadow register. BSEC_OTP_SRLOCK0 bit 0 is controlled by hardware according to fuse_ok, writing to this bit has no effect.
$5c005098 constant BSEC_BSEC_OTP_SRLOCK1  \ offset: 0x98 : BSEC_OTP_SRLOCK0 is used to prevent reloading of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SRLOCK1 is used to prevent reloading of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SRLOCK2 is used to prevent reloading of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Setting SRLOCK bits or attempt to reload a locked OTP do not clear the corresponding BSEC_OTP_DATAx shadow register. BSEC_OTP_SRLOCK0 bit 0 is controlled by hardware according to fuse_ok, writing to this bit has no effect.
$5c00509c constant BSEC_BSEC_OTP_SRLOCK2  \ offset: 0x9C : BSEC_OTP_SRLOCK0 is used to prevent reloading of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SRLOCK1 is used to prevent reloading of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SRLOCK2 is used to prevent reloading of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Setting SRLOCK bits or attempt to reload a locked OTP do not clear the corresponding BSEC_OTP_DATAx shadow register. BSEC_OTP_SRLOCK0 bit 0 is controlled by hardware according to fuse_ok, writing to this bit has no effect.
$5c0050ac constant BSEC_BSEC_JTAGIN  \ offset: 0xAC : BSEC JTAG input register
$5c0050b0 constant BSEC_BSEC_JTAGOUT  \ offset: 0xB0 : BSEC JTAG output register
$5c0050b4 constant BSEC_BSEC_SCRATCH  \ offset: 0xB4 : BSEC scratch register
$5c005200 constant BSEC_BSEC_OTP_DATA0  \ offset: 0x200 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005204 constant BSEC_BSEC_OTP_DATA1  \ offset: 0x204 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005208 constant BSEC_BSEC_OTP_DATA2  \ offset: 0x208 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c00520c constant BSEC_BSEC_OTP_DATA3  \ offset: 0x20C : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005210 constant BSEC_BSEC_OTP_DATA4  \ offset: 0x210 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005214 constant BSEC_BSEC_OTP_DATA5  \ offset: 0x214 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005218 constant BSEC_BSEC_OTP_DATA6  \ offset: 0x218 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c00521c constant BSEC_BSEC_OTP_DATA7  \ offset: 0x21C : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005220 constant BSEC_BSEC_OTP_DATA8  \ offset: 0x220 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005224 constant BSEC_BSEC_OTP_DATA9  \ offset: 0x224 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005228 constant BSEC_BSEC_OTP_DATA10  \ offset: 0x228 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c00522c constant BSEC_BSEC_OTP_DATA11  \ offset: 0x22C : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005230 constant BSEC_BSEC_OTP_DATA12  \ offset: 0x230 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005234 constant BSEC_BSEC_OTP_DATA13  \ offset: 0x234 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005238 constant BSEC_BSEC_OTP_DATA14  \ offset: 0x238 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c00523c constant BSEC_BSEC_OTP_DATA15  \ offset: 0x23C : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005240 constant BSEC_BSEC_OTP_DATA16  \ offset: 0x240 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005244 constant BSEC_BSEC_OTP_DATA17  \ offset: 0x244 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005248 constant BSEC_BSEC_OTP_DATA18  \ offset: 0x248 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c00524c constant BSEC_BSEC_OTP_DATA19  \ offset: 0x24C : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005250 constant BSEC_BSEC_OTP_DATA20  \ offset: 0x250 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005254 constant BSEC_BSEC_OTP_DATA21  \ offset: 0x254 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005258 constant BSEC_BSEC_OTP_DATA22  \ offset: 0x258 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c00525c constant BSEC_BSEC_OTP_DATA23  \ offset: 0x25C : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005260 constant BSEC_BSEC_OTP_DATA24  \ offset: 0x260 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005264 constant BSEC_BSEC_OTP_DATA25  \ offset: 0x264 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005268 constant BSEC_BSEC_OTP_DATA26  \ offset: 0x268 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c00526c constant BSEC_BSEC_OTP_DATA27  \ offset: 0x26C : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005270 constant BSEC_BSEC_OTP_DATA28  \ offset: 0x270 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005274 constant BSEC_BSEC_OTP_DATA29  \ offset: 0x274 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005278 constant BSEC_BSEC_OTP_DATA30  \ offset: 0x278 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c00527c constant BSEC_BSEC_OTP_DATA31  \ offset: 0x27C : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005280 constant BSEC_BSEC_OTP_DATA32  \ offset: 0x280 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005284 constant BSEC_BSEC_OTP_DATA33  \ offset: 0x284 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005288 constant BSEC_BSEC_OTP_DATA34  \ offset: 0x288 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c00528c constant BSEC_BSEC_OTP_DATA35  \ offset: 0x28C : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005290 constant BSEC_BSEC_OTP_DATA36  \ offset: 0x290 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005294 constant BSEC_BSEC_OTP_DATA37  \ offset: 0x294 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005298 constant BSEC_BSEC_OTP_DATA38  \ offset: 0x298 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c00529c constant BSEC_BSEC_OTP_DATA39  \ offset: 0x29C : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052a0 constant BSEC_BSEC_OTP_DATA40  \ offset: 0x2A0 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052a4 constant BSEC_BSEC_OTP_DATA41  \ offset: 0x2A4 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052a8 constant BSEC_BSEC_OTP_DATA42  \ offset: 0x2A8 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052ac constant BSEC_BSEC_OTP_DATA43  \ offset: 0x2AC : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052b0 constant BSEC_BSEC_OTP_DATA44  \ offset: 0x2B0 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052b4 constant BSEC_BSEC_OTP_DATA45  \ offset: 0x2B4 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052b8 constant BSEC_BSEC_OTP_DATA46  \ offset: 0x2B8 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052bc constant BSEC_BSEC_OTP_DATA47  \ offset: 0x2BC : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052c0 constant BSEC_BSEC_OTP_DATA48  \ offset: 0x2C0 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052c4 constant BSEC_BSEC_OTP_DATA49  \ offset: 0x2C4 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052c8 constant BSEC_BSEC_OTP_DATA50  \ offset: 0x2C8 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052cc constant BSEC_BSEC_OTP_DATA51  \ offset: 0x2CC : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052d0 constant BSEC_BSEC_OTP_DATA52  \ offset: 0x2D0 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052d4 constant BSEC_BSEC_OTP_DATA53  \ offset: 0x2D4 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052d8 constant BSEC_BSEC_OTP_DATA54  \ offset: 0x2D8 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052dc constant BSEC_BSEC_OTP_DATA55  \ offset: 0x2DC : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052e0 constant BSEC_BSEC_OTP_DATA56  \ offset: 0x2E0 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052e4 constant BSEC_BSEC_OTP_DATA57  \ offset: 0x2E4 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052e8 constant BSEC_BSEC_OTP_DATA58  \ offset: 0x2E8 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052ec constant BSEC_BSEC_OTP_DATA59  \ offset: 0x2EC : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052f0 constant BSEC_BSEC_OTP_DATA60  \ offset: 0x2F0 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052f4 constant BSEC_BSEC_OTP_DATA61  \ offset: 0x2F4 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052f8 constant BSEC_BSEC_OTP_DATA62  \ offset: 0x2F8 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c0052fc constant BSEC_BSEC_OTP_DATA63  \ offset: 0x2FC : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005300 constant BSEC_BSEC_OTP_DATA64  \ offset: 0x300 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005304 constant BSEC_BSEC_OTP_DATA65  \ offset: 0x304 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005308 constant BSEC_BSEC_OTP_DATA66  \ offset: 0x308 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c00530c constant BSEC_BSEC_OTP_DATA67  \ offset: 0x30C : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005310 constant BSEC_BSEC_OTP_DATA68  \ offset: 0x310 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005314 constant BSEC_BSEC_OTP_DATA69  \ offset: 0x314 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005318 constant BSEC_BSEC_OTP_DATA70  \ offset: 0x318 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c00531c constant BSEC_BSEC_OTP_DATA71  \ offset: 0x31C : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005320 constant BSEC_BSEC_OTP_DATA72  \ offset: 0x320 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005324 constant BSEC_BSEC_OTP_DATA73  \ offset: 0x324 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005328 constant BSEC_BSEC_OTP_DATA74  \ offset: 0x328 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c00532c constant BSEC_BSEC_OTP_DATA75  \ offset: 0x32C : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005330 constant BSEC_BSEC_OTP_DATA76  \ offset: 0x330 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005334 constant BSEC_BSEC_OTP_DATA77  \ offset: 0x334 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005338 constant BSEC_BSEC_OTP_DATA78  \ offset: 0x338 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c00533c constant BSEC_BSEC_OTP_DATA79  \ offset: 0x33C : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005340 constant BSEC_BSEC_OTP_DATA80  \ offset: 0x340 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005344 constant BSEC_BSEC_OTP_DATA81  \ offset: 0x344 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005348 constant BSEC_BSEC_OTP_DATA82  \ offset: 0x348 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c00534c constant BSEC_BSEC_OTP_DATA83  \ offset: 0x34C : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005350 constant BSEC_BSEC_OTP_DATA84  \ offset: 0x350 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005354 constant BSEC_BSEC_OTP_DATA85  \ offset: 0x354 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005358 constant BSEC_BSEC_OTP_DATA86  \ offset: 0x358 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c00535c constant BSEC_BSEC_OTP_DATA87  \ offset: 0x35C : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005360 constant BSEC_BSEC_OTP_DATA88  \ offset: 0x360 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005364 constant BSEC_BSEC_OTP_DATA89  \ offset: 0x364 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005368 constant BSEC_BSEC_OTP_DATA90  \ offset: 0x368 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c00536c constant BSEC_BSEC_OTP_DATA91  \ offset: 0x36C : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005370 constant BSEC_BSEC_OTP_DATA92  \ offset: 0x370 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005374 constant BSEC_BSEC_OTP_DATA93  \ offset: 0x374 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005378 constant BSEC_BSEC_OTP_DATA94  \ offset: 0x378 : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c00537c constant BSEC_BSEC_OTP_DATA95  \ offset: 0x37C : Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
$5c005ff0 constant BSEC_BSEC_HWCFGR  \ offset: 0xFF0 : BSEC hardware configuration register
$5c005ff4 constant BSEC_BSEC_VERR  \ offset: 0xFF4 : BSEC version register
$5c005ff8 constant BSEC_BSEC_IPIDR  \ offset: 0xFF8 : BSEC identification register
$5c005ffc constant BSEC_BSEC_SIDR  \ offset: 0xFFC : BSEC size identification register

